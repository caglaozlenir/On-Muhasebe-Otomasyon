﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı.StokModul
{
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmStokGruplari()
        {
            InitializeComponent();
        }
        private void frmStokGruplari_Load_1(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_STOKGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }
        void Temizle()
        {
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            Edit = false;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyon.TBL_STOKGRUPLARI Grup = new Fonksiyon.TBL_STOKGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Grup Kaydı Oluşturuldu.");
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
                Fonksiyon.TBL_STOKGRUPLARI Grup = DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID);
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPEDITUSER = AnaForm.UserID;
                Grup.GRUPEDITDATE = DateTime.Now;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
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
                DB.TBL_STOKGRUPLARIs.DeleteOnSubmit(DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}