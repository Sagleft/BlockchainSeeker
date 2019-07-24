using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Bitnet.Client;

namespace BlockchainSeeker
{
	public partial class MainForm : Form
	{
		BitnetClient client;
		List<string> known_addresses;
		List<string> known_transactions;
		
		public MainForm()
		{
			InitializeComponent();
			client = new BitnetClient("http://127.0.0.1:22823");
     		client.Credentials = new NetworkCredential("user", "password");
     		known_addresses = new List<string>() {
     			textBox_address.Text
     		};
     		known_transactions = new List<string>() {};
		}
		
		void updateLog(string info) {
			label_status.Text = info;
		}
		
		void EaterbtnClick(object sender, EventArgs e)
		{
			updateLog("by Sagleft");
		}
		
		void alert(string info) {
			MessageBox.Show(info, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void scanBlock(int block_number) {
			string block_hash = client.GetBlockHash(block_number);
			JArray arr = client.GetBlockTXs(block_hash);
			//проходим по транзакциям в блоке
			for(int i=0; i < arr.Count; i++) {
				//получаем ID транзакции
				string trid = arr[i].ToString();
				//Debug.Print("Разбираем транзакцию " + trid);
				//получаем данные транзакции
				JObject raw_trobj = client.GetRawTransaction(trid);
				
				//проходим по входам транзакции
				JArray tr_ints = raw_trobj["vin"] as JArray;
				bool ints_mined = false;
				bool tr_marked  = false;
				//Debug.Print("Всего входов: " + tr_ints.Count.ToString());
				for(int vin_n=0; vin_n < tr_ints.Count; vin_n++)
				{
					//получаем объект vin
					JObject vin_obj = tr_ints[vin_n] as JObject;
					//проверяем, не намайнены ли входы
					if(vin_obj.ContainsKey("txid") == false) {
						ints_mined = true;
						//Debug.Print("Считаем, что монеты намайнены, игнорируем выходы");
					} else {
						//проверим, известен ли данный trid
						string vin_trid = vin_obj["txid"].ToString();
						//Debug.Print("Достали vin trid: " + vin_trid);
						try {
							int tr_founded = known_transactions.IndexOf(vin_trid);
							if(tr_founded != -1) {
								//такая транзакция знакома, помечаем для записи адресов
								tr_marked = true;
								Debug.Print("Знакомый вход: " + vin_trid + ", пометили");
							}
						} catch(Exception ex) {
							Debug.Print("На блоке №" + block_number.ToString() + " ошибка: " + ex.Message + ", транзакция: " + trid + ", данные: " + vin_obj.ToString());
						}
					}
				}
				
				//если входы не намайнены
				if(!ints_mined) {
					//проходим по выходам транзакции
					JArray tr_outs = raw_trobj["vout"] as JArray;
					//Debug.Print("Всего выходов: " + tr_outs.Count.ToString());
					for(int vout_n=0; vout_n < tr_outs.Count && tr_outs.Count < 4; vout_n++)
					{
						//получаем объект vout
						JObject vout_obj = tr_outs[vout_n] as JObject;
						string addr_type = vout_obj["scriptPubKey"]["type"].ToString();
						if(addr_type != "nonstandard")
						{
							JArray addr_arr = vout_obj["scriptPubKey"]["addresses"] as JArray;
							for(int addr_index=0; addr_index < addr_arr.Count; addr_index++)
							{
								string vout_address = addr_arr[addr_index].ToString();
								//Debug.Print("Выходной адрес: " + vout_address);
								//если транзакция помечена, то записываем адреса
								if(tr_marked) {
									//Debug.Print("Транзакция была помечена, записываем адрес");
									known_addresses.Add(vout_address);
								} else {
									//Debug.Print("Транзакция не помечена.");
									//ищем знакомые адреса
									int addr_founded = known_addresses.IndexOf(vout_address);
									//Debug.Print("Позиция поиска адреса:" + addr_founded.ToString());
									if(addr_founded != -1) {
										//адрес знаком, запишем транзакцию
										known_transactions.Add(trid);
										//if(!ints_mined) {
										//	Debug.Print("Нашли транзакцию: " + trid);
										//}
									}
								}
							}
						} else {
							Debug.Print("Нашел сломанную транзакцию: " + addr_type);
						}
					}
				}
			}
		}
		
		void Button_scanClick(object sender, EventArgs e)
		{
			int block_from = 1;
			int blocks = client.GetBlockCount();
			int progress = 1;
			
			for(int block_number = block_from; block_number <= blocks; block_number++) {
				scanBlock(block_number);
				if(progress == 1001) {
					//Debug.Print("Блок №" + block_number.ToString());
					label_last_block.Text = block_number.ToString();
					label5.Text = known_addresses.Count.ToString();
					this.Refresh();
					progress = 1;
				}
				progress++;
			}
			File.WriteAllLines("adresses.txt", known_addresses);
			File.WriteAllLines("transactions.txt", known_transactions);
			Debug.Print("Сканирование завершено");
			alert("Сканирование завершено");
		}
		
		void ProgressTimerTick(object sender, EventArgs e)
		{
			//Debug.Print("Просканирован блок: " + progress.ToString());
		}
	}
}
