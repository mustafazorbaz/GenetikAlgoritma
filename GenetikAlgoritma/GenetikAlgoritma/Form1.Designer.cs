namespace GenetikAlgoritma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPopulasyonSayisi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxIslemler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMutasyonKatsayi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIslemleriGor = new System.Windows.Forms.CheckBox();
            this.comboBoxBireySec = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGenAdeti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxMutosyon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxFonksiyon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIterasyonSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPopulasyon = new System.Windows.Forms.ListBox();
            this.groupBoxIslemAdimlari = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSecilenler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxSonPopulasyon = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxGrafik = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxIslemAdimlari.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Populasyon Sayısı";
            // 
            // textBoxPopulasyonSayisi
            // 
            this.textBoxPopulasyonSayisi.Location = new System.Drawing.Point(109, 36);
            this.textBoxPopulasyonSayisi.Name = "textBoxPopulasyonSayisi";
            this.textBoxPopulasyonSayisi.Size = new System.Drawing.Size(140, 20);
            this.textBoxPopulasyonSayisi.TabIndex = 3;
            this.textBoxPopulasyonSayisi.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxIslemler
            // 
            this.listBoxIslemler.FormattingEnabled = true;
            this.listBoxIslemler.HorizontalScrollbar = true;
            this.listBoxIslemler.Location = new System.Drawing.Point(6, 45);
            this.listBoxIslemler.Name = "listBoxIslemler";
            this.listBoxIslemler.Size = new System.Drawing.Size(596, 225);
            this.listBoxIslemler.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMutasyonKatsayi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxIslemleriGor);
            this.groupBox1.Controls.Add(this.comboBoxBireySec);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxGenAdeti);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxMutosyon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxFonksiyon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIterasyonSayisi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPopulasyonSayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "Grafik Çizimi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMutasyonKatsayi
            // 
            this.textBoxMutasyonKatsayi.Location = new System.Drawing.Point(109, 114);
            this.textBoxMutasyonKatsayi.Name = "textBoxMutasyonKatsayi";
            this.textBoxMutasyonKatsayi.Size = new System.Drawing.Size(140, 20);
            this.textBoxMutasyonKatsayi.TabIndex = 18;
            this.textBoxMutasyonKatsayi.Text = "0,02";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mutasyon Katsayısı";
            // 
            // checkBoxIslemleriGor
            // 
            this.checkBoxIslemleriGor.AutoSize = true;
            this.checkBoxIslemleriGor.Location = new System.Drawing.Point(109, 189);
            this.checkBoxIslemleriGor.Name = "checkBoxIslemleriGor";
            this.checkBoxIslemleriGor.Size = new System.Drawing.Size(129, 17);
            this.checkBoxIslemleriGor.TabIndex = 16;
            this.checkBoxIslemleriGor.Text = "Yapılan Her Adımı Gör";
            this.checkBoxIslemleriGor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIslemleriGor.UseVisualStyleBackColor = true;
            // 
            // comboBoxBireySec
            // 
            this.comboBoxBireySec.FormattingEnabled = true;
            this.comboBoxBireySec.Items.AddRange(new object[] {
            "Karisik",
            "Rulet",
            "Rastgele",
            "Turnuva",
            "Deterministik"});
            this.comboBoxBireySec.Location = new System.Drawing.Point(109, 137);
            this.comboBoxBireySec.Name = "comboBoxBireySec";
            this.comboBoxBireySec.Size = new System.Drawing.Size(140, 21);
            this.comboBoxBireySec.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Birey Seç";
            // 
            // textBoxGenAdeti
            // 
            this.textBoxGenAdeti.Location = new System.Drawing.Point(109, 13);
            this.textBoxGenAdeti.Name = "textBoxGenAdeti";
            this.textBoxGenAdeti.Size = new System.Drawing.Size(140, 20);
            this.textBoxGenAdeti.TabIndex = 1;
            this.textBoxGenAdeti.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Gen Sayısı";
            // 
            // comboBoxMutosyon
            // 
            this.comboBoxMutosyon.FormattingEnabled = true;
            this.comboBoxMutosyon.Items.AddRange(new object[] {
            "Karisik",
            "Toplama",
            "Cikarma"});
            this.comboBoxMutosyon.Location = new System.Drawing.Point(109, 87);
            this.comboBoxMutosyon.Name = "comboBoxMutosyon";
            this.comboBoxMutosyon.Size = new System.Drawing.Size(140, 21);
            this.comboBoxMutosyon.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mutosyon";
            // 
            // comboBoxFonksiyon
            // 
            this.comboBoxFonksiyon.FormattingEnabled = true;
            this.comboBoxFonksiyon.Items.AddRange(new object[] {
            "Zakharov",
            "Beale",
            "Easom",
            "Michalewicz2",
            "Michalewicz5",
            "Michalewicz10"});
            this.comboBoxFonksiyon.Location = new System.Drawing.Point(109, 61);
            this.comboBoxFonksiyon.Name = "comboBoxFonksiyon";
            this.comboBoxFonksiyon.Size = new System.Drawing.Size(140, 21);
            this.comboBoxFonksiyon.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fonksiyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "İterasyon Sayısı";
            // 
            // textBoxIterasyonSayisi
            // 
            this.textBoxIterasyonSayisi.Location = new System.Drawing.Point(109, 163);
            this.textBoxIterasyonSayisi.Name = "textBoxIterasyonSayisi";
            this.textBoxIterasyonSayisi.Size = new System.Drawing.Size(140, 20);
            this.textBoxIterasyonSayisi.TabIndex = 7;
            this.textBoxIterasyonSayisi.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(229, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yapılan İşlemler";
            // 
            // listBoxPopulasyon
            // 
            this.listBoxPopulasyon.FormattingEnabled = true;
            this.listBoxPopulasyon.HorizontalScrollbar = true;
            this.listBoxPopulasyon.Location = new System.Drawing.Point(6, 32);
            this.listBoxPopulasyon.Name = "listBoxPopulasyon";
            this.listBoxPopulasyon.Size = new System.Drawing.Size(501, 238);
            this.listBoxPopulasyon.TabIndex = 7;
            // 
            // groupBoxIslemAdimlari
            // 
            this.groupBoxIslemAdimlari.Controls.Add(this.label5);
            this.groupBoxIslemAdimlari.Controls.Add(this.listBoxSecilenler);
            this.groupBoxIslemAdimlari.Controls.Add(this.label3);
            this.groupBoxIslemAdimlari.Controls.Add(this.listBoxIslemler);
            this.groupBoxIslemAdimlari.Location = new System.Drawing.Point(15, 307);
            this.groupBoxIslemAdimlari.Name = "groupBoxIslemAdimlari";
            this.groupBoxIslemAdimlari.Size = new System.Drawing.Size(1267, 285);
            this.groupBoxIslemAdimlari.TabIndex = 9;
            this.groupBoxIslemAdimlari.TabStop = false;
            this.groupBoxIslemAdimlari.Text = "Yeni Populasyon İçin Genetik Algoritma İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(768, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Populasyonlar";
            // 
            // listBoxSecilenler
            // 
            this.listBoxSecilenler.FormattingEnabled = true;
            this.listBoxSecilenler.HorizontalScrollbar = true;
            this.listBoxSecilenler.Location = new System.Drawing.Point(608, 45);
            this.listBoxSecilenler.Name = "listBoxSecilenler";
            this.listBoxSecilenler.Size = new System.Drawing.Size(649, 225);
            this.listBoxSecilenler.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İlk Populasyon";
            // 
            // listBoxSonPopulasyon
            // 
            this.listBoxSonPopulasyon.FormattingEnabled = true;
            this.listBoxSonPopulasyon.HorizontalScrollbar = true;
            this.listBoxSonPopulasyon.Location = new System.Drawing.Point(513, 32);
            this.listBoxSonPopulasyon.Name = "listBoxSonPopulasyon";
            this.listBoxSonPopulasyon.Size = new System.Drawing.Size(483, 238);
            this.listBoxSonPopulasyon.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(723, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Son  Populasyon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxPopulasyon);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listBoxSonPopulasyon);
            this.groupBox3.Location = new System.Drawing.Point(276, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1006, 285);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Populasyon";
            // 
            // groupBoxGrafik
            // 
            this.groupBoxGrafik.Controls.Add(this.chart2);
            this.groupBoxGrafik.Controls.Add(this.chart1);
            this.groupBoxGrafik.Controls.Add(this.label14);
            this.groupBoxGrafik.Controls.Add(this.label15);
            this.groupBoxGrafik.Location = new System.Drawing.Point(15, 310);
            this.groupBoxGrafik.Name = "groupBoxGrafik";
            this.groupBoxGrafik.Size = new System.Drawing.Size(1260, 264);
            this.groupBoxGrafik.TabIndex = 25;
            this.groupBoxGrafik.TabStop = false;
            this.groupBoxGrafik.Text = "Genetik Algoritma Grafik";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(571, 43);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(686, 217);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 43);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(503, 217);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(784, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Populasyonlardaki Değişim Grafiği";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(163, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(273, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "İlk ve Son Populasyon Değişim Grafigi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 595);
            this.Controls.Add(this.groupBoxIslemAdimlari);
            this.Controls.Add(this.groupBoxGrafik);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Genetik  Algoritma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIslemAdimlari.ResumeLayout(false);
            this.groupBoxIslemAdimlari.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxGrafik.ResumeLayout(false);
            this.groupBoxGrafik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPopulasyonSayisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxIslemler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIterasyonSayisi;
        private System.Windows.Forms.ListBox listBoxPopulasyon;
        private System.Windows.Forms.GroupBox groupBoxIslemAdimlari;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listBoxSonPopulasyon;
        private System.Windows.Forms.ListBox listBoxSecilenler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMutosyon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxFonksiyon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBireySec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGenAdeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxIslemleriGor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMutasyonKatsayi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

