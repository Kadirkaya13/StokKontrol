namespace StokKontrol.Forms
{
    partial class FrmStockUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYüklemeBosaltmaAlani = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.radioStatus0MK = new System.Windows.Forms.RadioButton();
            this.radioStatus1MK = new System.Windows.Forms.RadioButton();
            this.txtHasar = new System.Windows.Forms.TextBox();
            this.radioStatus0GK = new System.Windows.Forms.RadioButton();
            this.radioStatus1GK = new System.Windows.Forms.RadioButton();
            this.txtYerleştirme = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBosaltmaYontemi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radioStatus0 = new System.Windows.Forms.RadioButton();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.radioStatus1 = new System.Windows.Forms.RadioButton();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.txtStokTip = new System.Windows.Forms.TextBox();
            this.txtGenelAd = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtOzelKod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStokKodu = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYüklemeBosaltmaAlani);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.radioStatus0MK);
            this.groupBox1.Controls.Add(this.radioStatus1MK);
            this.groupBox1.Controls.Add(this.txtHasar);
            this.groupBox1.Controls.Add(this.radioStatus0GK);
            this.groupBox1.Controls.Add(this.radioStatus1GK);
            this.groupBox1.Controls.Add(this.txtYerleştirme);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtBosaltmaYontemi);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(571, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 311);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADRESLEME";
            // 
            // txtYüklemeBosaltmaAlani
            // 
            this.txtYüklemeBosaltmaAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYüklemeBosaltmaAlani.Location = new System.Drawing.Point(165, 181);
            this.txtYüklemeBosaltmaAlani.Name = "txtYüklemeBosaltmaAlani";
            this.txtYüklemeBosaltmaAlani.Size = new System.Drawing.Size(193, 29);
            this.txtYüklemeBosaltmaAlani.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(9, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 72);
            this.label17.TabIndex = 31;
            this.label17.Text = "Yükleme\r\nBosaltma \r\nAlanI";
            // 
            // radioStatus0MK
            // 
            this.radioStatus0MK.AutoSize = true;
            this.radioStatus0MK.Location = new System.Drawing.Point(217, 119);
            this.radioStatus0MK.Name = "radioStatus0MK";
            this.radioStatus0MK.Size = new System.Drawing.Size(48, 17);
            this.radioStatus0MK.TabIndex = 30;
            this.radioStatus0MK.TabStop = true;
            this.radioStatus0MK.Text = "Pasif";
            this.radioStatus0MK.UseVisualStyleBackColor = true;
            // 
            // radioStatus1MK
            // 
            this.radioStatus1MK.AutoSize = true;
            this.radioStatus1MK.Location = new System.Drawing.Point(165, 119);
            this.radioStatus1MK.Name = "radioStatus1MK";
            this.radioStatus1MK.Size = new System.Drawing.Size(46, 17);
            this.radioStatus1MK.TabIndex = 29;
            this.radioStatus1MK.TabStop = true;
            this.radioStatus1MK.Text = "Aktif";
            this.radioStatus1MK.UseVisualStyleBackColor = true;
            // 
            // txtHasar
            // 
            this.txtHasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHasar.Location = new System.Drawing.Point(165, 82);
            this.txtHasar.Name = "txtHasar";
            this.txtHasar.Size = new System.Drawing.Size(193, 29);
            this.txtHasar.TabIndex = 28;
            // 
            // radioStatus0GK
            // 
            this.radioStatus0GK.AutoSize = true;
            this.radioStatus0GK.Location = new System.Drawing.Point(217, 52);
            this.radioStatus0GK.Name = "radioStatus0GK";
            this.radioStatus0GK.Size = new System.Drawing.Size(48, 17);
            this.radioStatus0GK.TabIndex = 27;
            this.radioStatus0GK.TabStop = true;
            this.radioStatus0GK.Text = "Pasif";
            this.radioStatus0GK.UseVisualStyleBackColor = true;
            // 
            // radioStatus1GK
            // 
            this.radioStatus1GK.AutoSize = true;
            this.radioStatus1GK.Location = new System.Drawing.Point(165, 52);
            this.radioStatus1GK.Name = "radioStatus1GK";
            this.radioStatus1GK.Size = new System.Drawing.Size(46, 17);
            this.radioStatus1GK.TabIndex = 26;
            this.radioStatus1GK.TabStop = true;
            this.radioStatus1GK.Text = "Aktif";
            this.radioStatus1GK.UseVisualStyleBackColor = true;
            // 
            // txtYerleştirme
            // 
            this.txtYerleştirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYerleştirme.Location = new System.Drawing.Point(165, 146);
            this.txtYerleştirme.Name = "txtYerleştirme";
            this.txtYerleştirme.Size = new System.Drawing.Size(193, 29);
            this.txtYerleştirme.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Yerleştirme";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "Mal Kabul";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Hasar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = "Gecici Kabul";
            // 
            // txtBosaltmaYontemi
            // 
            this.txtBosaltmaYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBosaltmaYontemi.Location = new System.Drawing.Point(165, 15);
            this.txtBosaltmaYontemi.Name = "txtBosaltmaYontemi";
            this.txtBosaltmaYontemi.Size = new System.Drawing.Size(193, 29);
            this.txtBosaltmaYontemi.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 24);
            this.label16.TabIndex = 16;
            this.label16.Text = "Bosaltma Yontemi";
            // 
            // radioStatus0
            // 
            this.radioStatus0.AutoSize = true;
            this.radioStatus0.Location = new System.Drawing.Point(334, 403);
            this.radioStatus0.Name = "radioStatus0";
            this.radioStatus0.Size = new System.Drawing.Size(48, 17);
            this.radioStatus0.TabIndex = 48;
            this.radioStatus0.TabStop = true;
            this.radioStatus0.Text = "Pasif";
            this.radioStatus0.UseVisualStyleBackColor = true;
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockUpdate.Location = new System.Drawing.Point(443, 426);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(193, 34);
            this.btnStockUpdate.TabIndex = 47;
            this.btnStockUpdate.Text = "Güncelle";
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // radioStatus1
            // 
            this.radioStatus1.AutoSize = true;
            this.radioStatus1.Location = new System.Drawing.Point(282, 403);
            this.radioStatus1.Name = "radioStatus1";
            this.radioStatus1.Size = new System.Drawing.Size(46, 17);
            this.radioStatus1.TabIndex = 46;
            this.radioStatus1.TabStop = true;
            this.radioStatus1.Text = "Aktif";
            this.radioStatus1.UseVisualStyleBackColor = true;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(282, 362);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(193, 29);
            this.txtBarkod.TabIndex = 45;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(282, 330);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(193, 29);
            this.txtAdet.TabIndex = 44;
            // 
            // txtKdv
            // 
            this.txtKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdv.Location = new System.Drawing.Point(282, 296);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(193, 29);
            this.txtKdv.TabIndex = 43;
            this.txtKdv.Text = "18";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(282, 263);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(193, 29);
            this.txtSatisFiyat.TabIndex = 42;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(282, 228);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(193, 29);
            this.txtAlisFiyat.TabIndex = 41;
            // 
            // txtStokTip
            // 
            this.txtStokTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokTip.Location = new System.Drawing.Point(282, 195);
            this.txtStokTip.Name = "txtStokTip";
            this.txtStokTip.Size = new System.Drawing.Size(193, 29);
            this.txtStokTip.TabIndex = 40;
            // 
            // txtGenelAd
            // 
            this.txtGenelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelAd.Location = new System.Drawing.Point(282, 163);
            this.txtGenelAd.Name = "txtGenelAd";
            this.txtGenelAd.Size = new System.Drawing.Size(193, 29);
            this.txtGenelAd.TabIndex = 39;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(282, 129);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 29);
            this.txtAd.TabIndex = 38;
            // 
            // txtOzelKod
            // 
            this.txtOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzelKod.Location = new System.Drawing.Point(282, 96);
            this.txtOzelKod.Name = "txtOzelKod";
            this.txtOzelKod.Size = new System.Drawing.Size(193, 29);
            this.txtOzelKod.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(169, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Durum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(169, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Barkod";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(169, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(169, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kdv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(169, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(169, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(169, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Stok Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(169, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Genel Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(169, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ozel Kod";
            // 
            // cbxStokKodu
            // 
            this.cbxStokKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxStokKodu.FormattingEnabled = true;
            this.cbxStokKodu.Location = new System.Drawing.Point(500, 25);
            this.cbxStokKodu.Name = "cbxStokKodu";
            this.cbxStokKodu.Size = new System.Drawing.Size(193, 28);
            this.cbxStokKodu.TabIndex = 50;
            this.cbxStokKodu.SelectedIndexChanged += new System.EventHandler(this.cbxStokKodu_SelectedIndexChanged);
            this.cbxStokKodu.ValueMemberChanged += new System.EventHandler(this.cbxStokKodu_ValueMemberChanged);
            this.cbxStokKodu.SelectedValueChanged += new System.EventHandler(this.cbxStokKodu_SelectedValueChanged);
            this.cbxStokKodu.TextChanged += new System.EventHandler(this.cbxStokKodu_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(398, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 24);
            this.label18.TabIndex = 51;
            this.label18.Text = "Stok Kodu";
            // 
            // FrmStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 576);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxStokKodu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioStatus0);
            this.Controls.Add(this.btnStockUpdate);
            this.Controls.Add(this.radioStatus1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtStokTip);
            this.Controls.Add(this.txtGenelAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtOzelKod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmStockUpdate";
            this.Text = "FrmStockUpdate";
            this.Load += new System.EventHandler(this.FrmStockUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYüklemeBosaltmaAlani;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioStatus0MK;
        private System.Windows.Forms.RadioButton radioStatus1MK;
        private System.Windows.Forms.TextBox txtHasar;
        private System.Windows.Forms.RadioButton radioStatus0GK;
        private System.Windows.Forms.RadioButton radioStatus1GK;
        private System.Windows.Forms.TextBox txtYerleştirme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBosaltmaYontemi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioStatus0;
        private System.Windows.Forms.Button btnStockUpdate;
        private System.Windows.Forms.RadioButton radioStatus1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.TextBox txtStokTip;
        private System.Windows.Forms.TextBox txtGenelAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtOzelKod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStokKodu;
        private System.Windows.Forms.Label label18;
    }
}