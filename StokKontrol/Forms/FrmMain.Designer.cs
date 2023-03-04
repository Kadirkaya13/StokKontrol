namespace StokKontrol.Forms
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnStokGüncelle = new System.Windows.Forms.Button();
            this.btnStockDel = new System.Windows.Forms.Button();
            this.btnStockList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(40, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 149);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stok Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStokGüncelle
            // 
            this.btnStokGüncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStokGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokGüncelle.Location = new System.Drawing.Point(283, 27);
            this.btnStokGüncelle.Name = "btnStokGüncelle";
            this.btnStokGüncelle.Size = new System.Drawing.Size(237, 149);
            this.btnStokGüncelle.TabIndex = 1;
            this.btnStokGüncelle.Text = "Stok Güncelle";
            this.btnStokGüncelle.UseVisualStyleBackColor = false;
            this.btnStokGüncelle.Click += new System.EventHandler(this.btnStokGüncelle_Click);
            // 
            // btnStockDel
            // 
            this.btnStockDel.BackColor = System.Drawing.Color.Red;
            this.btnStockDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockDel.Location = new System.Drawing.Point(40, 182);
            this.btnStockDel.Name = "btnStockDel";
            this.btnStockDel.Size = new System.Drawing.Size(237, 149);
            this.btnStockDel.TabIndex = 2;
            this.btnStockDel.Text = "Stok Sil";
            this.btnStockDel.UseVisualStyleBackColor = false;
            this.btnStockDel.Click += new System.EventHandler(this.btnStockDel_Click);
            // 
            // btnStockList
            // 
            this.btnStockList.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStockList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockList.Location = new System.Drawing.Point(283, 182);
            this.btnStockList.Name = "btnStockList";
            this.btnStockList.Size = new System.Drawing.Size(237, 149);
            this.btnStockList.TabIndex = 3;
            this.btnStockList.Text = "Stok Listele";
            this.btnStockList.UseVisualStyleBackColor = false;
            this.btnStockList.Click += new System.EventHandler(this.btnStockList_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(526, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 149);
            this.button2.TabIndex = 5;
            this.button2.Text = "AdresRaporlama";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(526, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 149);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stok Raporlama";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStockList);
            this.Controls.Add(this.btnStockDel);
            this.Controls.Add(this.btnStokGüncelle);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStokGüncelle;
        private System.Windows.Forms.Button btnStockDel;
        private System.Windows.Forms.Button btnStockList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}