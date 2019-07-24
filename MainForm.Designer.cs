/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 17.07.2019
 * Время: 23:56
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace BlockchainSeeker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label_status = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_last_block = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button_scan = new System.Windows.Forms.Button();
			this.textBox_address = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.eaterbtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar.Location = new System.Drawing.Point(0, 392);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(794, 23);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 2;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(794, 392);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label_status);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label_last_block);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Controls.Add(this.button_scan);
			this.tabPage1.Controls.Add(this.textBox_address);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 37);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(786, 351);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Сканирование";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label_status
			// 
			this.label_status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_status.Location = new System.Drawing.Point(374, 311);
			this.label_status.Name = "label_status";
			this.label_status.Size = new System.Drawing.Size(406, 35);
			this.label_status.TabIndex = 21;
			this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(463, 239);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(259, 37);
			this.button3.TabIndex = 19;
			this.button3.Text = "Экспорт в TXT";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(463, 197);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(259, 37);
			this.button2.TabIndex = 20;
			this.button2.Text = "Экспорт в CSV";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(665, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 34);
			this.label5.TabIndex = 17;
			this.label5.Text = "0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(463, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 34);
			this.label4.TabIndex = 18;
			this.label4.Text = "Всего найдено:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_last_block
			// 
			this.label_last_block.Location = new System.Drawing.Point(205, 83);
			this.label_last_block.Name = "label_last_block";
			this.label_last_block.Size = new System.Drawing.Size(163, 36);
			this.label_last_block.TabIndex = 16;
			this.label_last_block.Text = "0";
			this.label_last_block.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 36);
			this.label3.TabIndex = 15;
			this.label3.Text = "Последний блок:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 23;
			this.listBox1.Location = new System.Drawing.Point(17, 122);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(351, 207);
			this.listBox1.TabIndex = 14;
			// 
			// button_scan
			// 
			this.button_scan.Location = new System.Drawing.Point(463, 18);
			this.button_scan.Name = "button_scan";
			this.button_scan.Size = new System.Drawing.Size(312, 37);
			this.button_scan.TabIndex = 13;
			this.button_scan.Text = "Сканировать";
			this.button_scan.UseVisualStyleBackColor = true;
			this.button_scan.Click += new System.EventHandler(this.Button_scanClick);
			// 
			// textBox_address
			// 
			this.textBox_address.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_address.Location = new System.Drawing.Point(183, 27);
			this.textBox_address.Name = "textBox_address";
			this.textBox_address.Size = new System.Drawing.Size(263, 23);
			this.textBox_address.TabIndex = 12;
			this.textBox_address.TabStop = false;
			this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 33);
			this.label1.TabIndex = 10;
			this.label1.Text = "Целевой адрес:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.eaterbtn);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(786, 363);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Информация";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// eaterbtn
			// 
			this.eaterbtn.FlatAppearance.BorderSize = 0;
			this.eaterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eaterbtn.Location = new System.Drawing.Point(713, 32);
			this.eaterbtn.Name = "eaterbtn";
			this.eaterbtn.Size = new System.Drawing.Size(42, 37);
			this.eaterbtn.TabIndex = 22;
			this.eaterbtn.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox1.Location = new System.Drawing.Point(34, 113);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(721, 212);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "server=1\r\nlisten=1\r\nrpcport=22823\r\nrpcuser=user\r\nrpcpassword=password\r\nrpcallowip" +
			"=127.0.0.1\r\ntxindex=1";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(34, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(721, 37);
			this.label6.TabIndex = 0;
			this.label6.Text = "2. Содержимое .conf файла должно быть:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(721, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "1. Кошелек должен быть запущен.";
			// 
			// progressTimer
			// 
			this.progressTimer.Interval = 1000;
			this.progressTimer.Tick += new System.EventHandler(this.ProgressTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(794, 415);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.progressBar);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Blockchain Seeker - соло-майнер не пройдет";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer progressTimer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button eaterbtn;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_last_block;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button_scan;
		private System.Windows.Forms.Label label_status;
		private System.Windows.Forms.TextBox textBox_address;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label label1;
	}
}
