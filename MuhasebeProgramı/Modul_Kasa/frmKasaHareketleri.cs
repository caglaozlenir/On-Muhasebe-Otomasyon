using DevExpress.XtraEditors;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Kasa
{
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();

        int HareketID = -1;
        int KasaID = -1;
        string EvrakTURU;
        int EvrakID = -1;


        public frmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }

        public void Ac(int ID)
        {
            try
            { 
                KasaID = ID;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void DurumGetir()
        {
            Fonksiyon.VW_KASADURUM Kasa = DB.VW_KASADURUMs.First(s => s.KASAID == KasaID);
            txtGiris.Text = Kasa.GIRIS.Value.ToString();
            txtCikis.Text = Kasa.CIKIS.Value.ToString();
            txtBakiye.Text = Kasa.BAKIYE.Value.ToString();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERIs
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }

        }

        private void txtKasaKodu_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());
                }
                catch(Exception)
                {
                    EvrakID = -1;
                }
                EvrakTURU = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch(Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                EvrakTURU = "";
            }
        }
        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (EvrakTURU == "Kasa Devir Kartı")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled = false;
            }
            else if (EvrakTURU == "Kasa Tahsilat" || EvrakTURU == "Kasa Ödeme")
            {
                DevirKartiDuzenle.Enabled = false;
                TahsilatOdemeDuzenle.Enabled = true;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevirIslemKarti(true, HareketID);
            Listele();
        }

        private void TahsilatOdemeDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti(true, HareketID);
            Listele();
        }

        private void SagTik_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}