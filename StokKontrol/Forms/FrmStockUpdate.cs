using System;
using System.Linq;
using System.Windows.Forms;

namespace StokKontrol.Forms
{
    public partial class FrmStockUpdate : Form
    {
        public FrmStockUpdate()
        {
            InitializeComponent();
        }
        private StokDbEntities _db = new StokDbEntities();

        private void FrmStockUpdate_Load(object sender, EventArgs e)
        {
          CategorySelection();
          GetProduct();
        }
        void CategorySelection()
        {
            cbxStokKodu.DataSource = _db.StokKart.Select(p => p.StokKodu).ToList();
        }
        void GetProduct()
        {

            var id = cbxStokKodu.SelectedValue.ToString();
            var stokKart = _db.StokKart.Where(x => x.StokKodu == id).FirstOrDefault();
            var adresleme = _db.Adresleme.Where(x => x.StokKodu == id).FirstOrDefault();

            string stokKod = cbxStokKodu.Text;
            if (stokKod != "")
            {

 
                txtOzelKod.Text = stokKart.OzelKod;
                txtAd.Text = stokKart.Ad;
                txtGenelAd.Text = stokKart.GenelAd;
                txtAlisFiyat.Text = stokKart.AlışFiyat.ToString();
                txtSatisFiyat.Text = stokKart.SatışFiyat.ToString();
                txtAdet.Text = stokKart.Adet.ToString();
                txtKdv.Text = stokKart.Kdv.ToString(); 
                txtStokTip.Text = stokKart.StokTipi;
                txtBarkod.Text = stokKart.Barkod;
                if (stokKart.Durum == false)
                {
                    stokKart.Durum = radioStatus1.Checked;
                }
                else
                {
                    stokKart.Durum = radioStatus0.Checked;
                } 


                txtBosaltmaYontemi.Text = adresleme.BosaltmaYontemi;
                radioStatus1GK.Checked = adresleme.GeciciKabul == true;
                radioStatus1MK.Checked = adresleme.MalKabul == true;
                txtYerleştirme.Text = adresleme.Yerleştirme;
                txtYüklemeBosaltmaAlani.Text = adresleme.YüklemeBosaltmaAlani;
            }
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            var id = cbxStokKodu.SelectedValue.ToString();
            var stokKart = _db.StokKart.Find(id);
            var adresleme = _db.Adresleme.Find(id);

            if (txtAdet.Text != null && txtAd.Text != "" && txtStokTip.Text != "" && txtAlisFiyat.Text != null && txtSatisFiyat.Text != null
                 && txtBosaltmaYontemi.Text != "" && txtYerleştirme.Text != "" && txtYüklemeBosaltmaAlani.Text != "")
            {

                stokKart.OzelKod = txtOzelKod.Text;
                stokKart.Ad = txtAd.Text;
                stokKart.GenelAd = txtGenelAd.Text;
                stokKart.AlışFiyat = Convert.ToInt32(txtAlisFiyat.Text);
                stokKart.SatışFiyat = Convert.ToInt32(txtSatisFiyat.Text);
                stokKart.Adet = Convert.ToInt32(txtAdet.Text);
                stokKart.Kdv = Convert.ToInt32(txtSatisFiyat.Text) * (Convert.ToInt32(1 + txtKdv.Text));
                stokKart.StokTipi = txtStokTip.Text;
                stokKart.Barkod = txtBarkod.Text;
                stokKart.Durum = Convert.ToInt32(radioStatus1.Checked) > 0 ? true : false;

                adresleme.BosaltmaYontemi = txtBosaltmaYontemi.Text;
                adresleme.GeciciKabul = Convert.ToInt32(radioStatus1GK.Checked) > 0 ? true : false;
                adresleme.MalKabul = Convert.ToInt32(radioStatus1MK.Checked) > 0 ? true : false;
                adresleme.Yerleştirme = txtYerleştirme.Text;
                adresleme.YüklemeBosaltmaAlani = txtYüklemeBosaltmaAlani.Text;

                _db.SaveChanges();

                MessageBox.Show("Ürün başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Doldurulmayan alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxStokKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void cbxStokKodu_TextChanged(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void cbxStokKodu_ValueMemberChanged(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void cbxStokKodu_SelectedValueChanged(object sender, EventArgs e)
        {
            GetProduct();
        }
    }
}
