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
    public partial class frmBankaİslem : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;
        public frmBankaİslem()
        {
            InitializeComponent();
        }

        private void frmBankaİslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyon.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;


            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_BANKAHAREKETLERI Hareket = new Fonksiyon.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Banka işlemi kaydı yapılmıştır.");
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
                Fonksiyon.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
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
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
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
    }
}