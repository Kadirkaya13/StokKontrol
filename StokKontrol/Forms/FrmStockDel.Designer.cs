namespace StokKontrol.Forms
{
    partial class FrmStockDel
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
            this.label18 = new System.Windows.Forms.Label();
            this.cbxStokKodu = new System.Windows.Forms.ComboBox();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(48, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 24);
            this.label18.TabIndex = 53;
            this.label18.Text = "Stok Kodu";
            // 
            // cbxStokKodu
            // 
            this.cbxStokKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxStokKodu.FormattingEnabled = true;
            this.cbxStokKodu.Location = new System.Drawing.Point(150, 39);
            this.cbxStokKodu.Name = "cbxStokKodu";
            this.cbxStokKodu.Size = new System.Drawing.Size(193, 28);
            this.cbxStokKodu.TabIndex = 52;
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.BackColor = System.Drawing.Color.Red;
            this.btnStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockUpdate.Location = new System.Drawing.Point(150, 86);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(193, 34);
            this.btnStockUpdate.TabIndex = 54;
            this.btnStockUpdate.Text = "Sil";
            this.btnStockUpdate.UseVisualStyleBackColor = false;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // FrmStockDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 143);
            this.Controls.Add(this.btnStockUpdate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxStokKodu);
            this.Name = "FrmStockDel";
            this.Text = "FrStockDel";
            this.Load += new System.EventHandler(this.FrmStockDel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxStokKodu;
        private System.Windows.Forms.Button btnStockUpdate;
    }
}