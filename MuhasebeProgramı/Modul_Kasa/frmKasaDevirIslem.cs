using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.Modul_Kasa
{
    public partial class frmKasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;
        public frmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_KASAHAREKETLERI Hareket = new Fonksiyon.TBL_KASAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Devir Kartı Hareket Kaydı İşlenmiştir");
                Temizle();


            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyon.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
}

        void Sil()
        {
            try
            {
                DB.TBL_KASAHAREKETLERIs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyon.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;

            }
            catch (Exception)
            {
               
            }
        }

       private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}