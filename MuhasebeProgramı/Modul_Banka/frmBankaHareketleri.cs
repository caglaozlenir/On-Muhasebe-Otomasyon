using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Banka
{
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();

        int IslemID = -1;
        int BankaID = -1;
        string EvrakTURU;
        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            var lst = from s in DB.TBL_BANKAHAREKETLERIs
                      where s.BANKAID == BankaID
                      select s;
            Liste.DataSource = lst;
        }


        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyon.VW_BANKALISTESI Banka = DB.VW_BANKALISTESIs.First(s => s.ID == BankaID);
                txtHesapAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtGiris.Text = Banka.GIRIS.Value.ToString();
                txtCikis.Text = Banka.CIKIS.Value.ToString();
                txtBakiye.Text = Banka.BAKIYE.Value.ToString();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        { 
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        void Sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                EvrakTURU = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();

            }
            catch (Exception)
            {
                IslemID = -1;
                EvrakTURU = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
           
        }


        
        private void BankaIslemiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true, IslemID);
            Listele();
        }

        private void ParaTransferiDuzenle_Click_1(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            Listele();
        }

        private void SagTik_Opening_1(object sender, CancelEventArgs e)
        {

            Sec();
            if (IslemID > 0)
            {
                if (EvrakTURU == "Banka İşlem")
                {
                    BankaIslemiDuzenle.Enabled = true;
                    ParaTransferiDuzenle.Enabled = false;
                }
                else if (EvrakTURU == "Banka EFT" || EvrakTURU == "Banka Havalesi")
                {
                    BankaIslemiDuzenle.Enabled = false;
                    ParaTransferiDuzenle.Enabled = true;
                }
            }
        }
    }
}