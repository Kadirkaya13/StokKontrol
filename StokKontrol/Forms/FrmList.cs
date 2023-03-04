using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using StokKontrol.Dtos;

namespace StokKontrol.Forms
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private StokDbEntities _db = new StokDbEntities();

        private void FrmList_Load(object sender, EventArgs e)
        {

            var veriler = from Stok in _db.StokKart
                join Adres in _db.Adresleme
                    on Stok.StokKodu equals Adres.StokKodu
                where Stok.StokKodu == Adres.StokKodu
                select new StokAdresDto()
                {
                    StokKodu = Stok.StokKodu,
                    OzelKod = Stok.OzelKod,
                    Barkod = Stok.Barkod,
                    Ad = Stok.Ad,
                    GenelAd = Stok.GenelAd,
                    StokTipi = Stok.StokTipi,
                    AlışFiyat = Stok.AlışFiyat,
                    SatışFiyat = Stok.SatışFiyat,
                    Kdv = Stok.Kdv,
                    Adet = Stok.Adet,
                    BosaltmaYontemi = Adres.BosaltmaYontemi,
                    YüklemeBosaltmaAlani = Adres.YüklemeBosaltmaAlani,
                    Yerleştirme = Adres.Yerleştirme,
                    GeciciKabul = Adres.GeciciKabul,
                    MalKabul = Adres.MalKabul,
                    Hasar = Adres.Hasar,
                    Durum = Stok.Durum

                };

            dataGridView1.DataSource = veriler.ToList();

        }
    }
}
