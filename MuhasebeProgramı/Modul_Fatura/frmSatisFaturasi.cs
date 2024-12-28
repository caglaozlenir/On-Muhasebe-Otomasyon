using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using MuhasebeProgramı.Fonksiyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MuhasebeProgramı.Modul_Fatura
{
    public partial class frmSatisFaturasi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Mesajlar Mesajlar = new Fonksiyon.Mesajlar();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;
        int IrsaliyeID = -1;
        string OdemeYeri = "";
        bool Edit = false;
        bool IrsaliyeAc = false;

        void Temizle()
        {
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsaliyeID = -1;
            OdemeYeri = "";
            Edit = false;
            IrsaliyeAc = false;
            txtAciklama.Text = "";
            txtAraToplam.Text = "0.00";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtFaturaTuru.SelectedIndex = 0;
            txtGenelToplam.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIrsaliyeNo.Text = "";
            txtIrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtKDV.Text = "0.00";
            txtOdemeYeri.SelectedIndex = 0;
            AnaForm.Aktarma = -1;
            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);
            }
        }

        void FaturaGetir()
        {
            try
            {
                Fonksiyon.TBL_FATURALAR Fatura = DB.TBL_FATURALARs.First(s => s.ID == FaturaID);
                IrsaliyeID = Fatura.IRSALIYEID.Value;
                txtAciklama.Text = Fatura.ACIKLAMA;
                txtFaturaNo.Text = Fatura.FATURANO;
                if (Fatura.ODEMEYERIID > 0)
                {
                    txtFaturaTuru.SelectedIndex = 1;

                    if (Fatura.ODEMEYERI == "Kasa")
                    {
                        txtOdemeYeri.SelectedIndex = 0;
                        OdemeYeri = Fatura.ODEMEYERI;
                        txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == Fatura.ODEMEYERIID.Value).KASAADI;
                        txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == Fatura.ODEMEYERIID.Value).KASAKODU;
                    }
                    else if (Fatura.ODEMEYERI == "Banka")
                    {
                        txtOdemeYeri.SelectedIndex = 1;
                        OdemeYeri = Fatura.ODEMEYERI;
                        txtHesapAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == Fatura.ODEMEYERIID.Value).HESAPADI;
                        txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == Fatura.ODEMEYERIID.Value).HESAPNO;
                    }
                    OdemeID = Fatura.ODEMEYERIID.Value;

                }
                else if (Fatura.ODEMEYERIID < 1) txtFaturaTuru.SelectedIndex = 0;
                txtIrsaliyeNo.Text = DB.TBL_IRSALIYELERs.First(s => s.ID == Fatura.IRSALIYEID).IRSALIYENO;
                txtIrsaliyeTarihi.EditValue = DB.TBL_IRSALIYELERs.First(s => s.ID == Fatura.IRSALIYEID).TARIHI.Value.ToShortDateString();
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.CARIKODU == Fatura.CARIKODU).CARIADI;
                txtCariKodu.Text = Fatura.CARIKODU;
                txtFaturaTarihi.EditValue = Fatura.TARIHI.Value.ToShortDateString();
                var srg = from s in DB.VW_KALEMLERs
                          where s.FATURAID == FaturaID
                          select s;
                foreach (Fonksiyon.VW_KALEMLER k in srg)
                {
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("MIKTAR", k.MIKTAR);
                    gridView1.SetFocusedRowCellValue("BARKOD", k.STOKBARKOD);
                    gridView1.SetFocusedRowCellValue("STOKKODU", k.STOKKODU);
                    gridView1.SetFocusedRowCellValue("STOKADI", k.STOKADI);
                    gridView1.SetFocusedRowCellValue("BIRIM", k.STOKBIRIM);
                    gridView1.SetFocusedRowCellValue("BIRIMFIYAT", k.BIRIMFIYAT);
                    gridView1.SetFocusedRowCellValue("KDV", k.KDV);
                    gridView1.UpdateCurrentRow();

                }

            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        public frmSatisFaturasi()
        {
            InitializeComponent();
        }

        public frmSatisFaturasi(bool Ac, int ID, bool Irsaliye)
        {
            InitializeComponent();
            Edit = Ac;
            if (Irsaliye) IrsaliyeID = ID;
            else FaturaID = ID;
            IrsaliyeAc = Irsaliye;
            this.Shown += FrmSatisFaturasi_Shown;
        }

        private void FrmSatisFaturasi_Shown(object sender, EventArgs e)
        {
            if (Edit) FaturaGetir();
        }

        void StokGetir(int StokID)
        {
            try
            {
                Fonksiyon.TBL_STOKLAR Stok = DB.TBL_STOKLARs.First(s => s.ID == StokID);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("MIKTAR", "0");
                gridView1.SetFocusedRowCellValue("BARKOD", Stok.STOKBARKOD);
                gridView1.SetFocusedRowCellValue("STOKKODU", Stok.STOKKODU);
                gridView1.SetFocusedRowCellValue("STOKADI", Stok.STOKADI);
                gridView1.SetFocusedRowCellValue("BIRIM", Stok.STOKBIRIM);
                gridView1.SetFocusedRowCellValue("BIRIMFIYAT", Stok.STOKSATISFIYAT);
                gridView1.SetFocusedRowCellValue("KDV", Stok.STOKSATISKDV);
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        private void btnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StokID = Formlar.StokListesi(true);
            if (StokID > 0)
            {
                StokGetir(StokID);
            }
            AnaForm.Aktarma = -1;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSatisFaturasi_Load(object sender, EventArgs e)
        {
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtIrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal Miktar = 0, BirimFiyat = 0, Toplam = 0;

                if (e.Column.Name != "colTOPLAM")
                {
                    Miktar = decimal.Parse(gridView1.GetFocusedRowCellValue("MIKTAR").ToString());
                    if (gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString() != "") BirimFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString());
                    Toplam = Miktar * BirimFiyat;

                    gridView1.SetFocusedRowCellValue("TOPLAM", Toplam.ToString());
                    Hesapla();
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        void Hesapla()
        {
            try
            {
                decimal BirimFiyat = 0, Miktar = 0, GenelToplam = 0, AraToplam = 0, KDV = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    Miktar = decimal.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString()) / 100 + 1;
                    AraToplam += Miktar * BirimFiyat;
                    GenelToplam += decimal.Parse(gridView1.GetRowCellValue(i, "TOPLAM").ToString()) * KDV;
                }

                txtAraToplam.Text = AraToplam.ToString("0.00");
                txtKDV.Text = (GenelToplam - AraToplam).ToString("0,00");
                txtGenelToplam.Text = GenelToplam.ToString("0.00");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0) CariSec(ID);
            AnaForm.Aktarma = -1;
        }

        void CariSec(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyon.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                txtCariKodu.Text = Cari.CARIKODU;
                txtCariAdi.Text = Cari.CARIADI;
            }
            catch (Exception EX)
            {
                Mesajlar.Hata(EX);
            }
        }

        private void txtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFaturaTuru.SelectedIndex == 0)
            {
                pnlOdemeYerleri.Enabled = false;
                txtOdemeYeri.Enabled = false;
            }
            if (txtFaturaTuru.SelectedIndex == 1)
            {
                pnlOdemeYerleri.Enabled = true;
                txtOdemeYeri.Enabled = true;
            }
        }

        private void txtOdemeYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtOdemeYeri.SelectedIndex == 0)
            {
                txtHesapAdi.Enabled = false;
                txtHesapNo.Enabled = false;
                txtCariAdi.Enabled = true;
                txtKasaKodu.Enabled = true;
                OdemeYeri = txtOdemeYeri.Text;
            }
            if (txtOdemeYeri.SelectedIndex == 1)
            {
                txtHesapAdi.Enabled = true;
                txtHesapNo.Enabled = true;
                txtKasaKodu.Enabled = false;
                txtKasaAdi.Enabled = false;
                OdemeYeri = txtOdemeYeri.Text;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void YeniFaturaKaydet()
        {
            try
            {
                Fonksiyon.TBL_FATURALAR Fatura = new Fonksiyon.TBL_FATURALAR();
                Fatura.ACIKLAMA = txtAciklama.Text;
                Fatura.CARIKODU = txtCariKodu.Text;
                Fatura.FATURANO = txtFaturaNo.Text;
                Fatura.FATURATURU = "Satış Faturası";
                Fatura.GENELTOPLAM = decimal.Parse(txtGenelToplam.Text);
                Fatura.IRSALIYEID = IrsaliyeID;
                Fatura.ODEMEYERI = OdemeYeri;
                Fatura.ODEMEYERIID = OdemeID;
                Fatura.TARIHI = DateTime.Parse(txtFaturaTarihi.Text);
                Fatura.SAVEDATE = DateTime.Now;
                Fatura.SAVEUSER = AnaForm.UserID;
                DB.TBL_FATURALARs.InsertOnSubmit(Fatura);
                DB.SubmitChanges();
                FaturaID = Fatura.ID;
                if (IrsaliyeID < 0)
                {
                    Fonksiyon.TBL_IRSALIYELER Irsaliye = new Fonksiyon.TBL_IRSALIYELER();
                    Irsaliye.ACIKLAMA = txtAciklama.Text;
                    Irsaliye.CARIKODU = txtCariKodu.Text;
                    Irsaliye.FATURAID = Fatura.ID;
                    Irsaliye.TARIHI = DateTime.Parse(txtIrsaliyeTarihi.Text);
                    Irsaliye.SAVEDATE = DateTime.Now;
                    Irsaliye.SAVEUSER = AnaForm.UserID;
                    DB.TBL_IRSALIYELERs.InsertOnSubmit(Irsaliye);
                    DB.SubmitChanges();
                    IrsaliyeID = Irsaliye.ID;
                    Fatura.IRSALIYEID = IrsaliyeID;
                }
                Fonksiyon.TBL_STOKHAREKETLERI[] StokHareketi = new Fonksiyon.TBL_STOKHAREKETLERI[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    StokHareketi[i] = new Fonksiyon.TBL_STOKHAREKETLERI();
                    StokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    StokHareketi[i].FATURAID = Fatura.ID;
                    StokHareketi[i].GCKODU = "C";
                    StokHareketi[i].IRSALIYEID = IrsaliyeID;
                    StokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                    StokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    StokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
                    StokHareketi[i].TIPI = "Satış Faturası";
                    StokHareketi[i].SAVEDATE = DateTime.Now;
                    StokHareketi[i].SAVEUSER = AnaForm.UserID;
                    DB.TBL_STOKHAREKETLERIs.InsertOnSubmit(StokHareketi[i]);
                }
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = new Fonksiyon.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtFaturaNo.Text + " no'lu satış faturası tutarı.";
                if (txtFaturaTuru.SelectedIndex == 0)
                {
                    CariHareket.ALACAK = 0;
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                }
                else if (txtFaturaTuru.SelectedIndex == 1)
                {
                    CariHareket.ALACAK = decimal.Parse(txtGenelToplam.Text);
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                }
                CariHareket.CARIID = CariID;
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "SF";
                CariHareket.EVRAKTURU = "Satış Faturası";
                CariHareket.EVRAKID = Fatura.ID;
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Fatura Kaydı Başarı İle Yapılmıştır.");
                Temizle();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        void FaturaGuncelle()
        {
            try
            {
                Fonksiyon.TBL_FATURALAR Fatura = DB.TBL_FATURALARs.First(s => s.ID == FaturaID);
                Fatura.FATURANO = txtFaturaNo.Text;
                Fatura.ACIKLAMA = txtAciklama.Text;
                Fatura.CARIKODU = txtCariKodu.Text;
                Fatura.GENELTOPLAM = decimal.Parse(txtGenelToplam.Text);
                Fatura.ODEMEYERI = OdemeYeri;
                Fatura.ODEMEYERIID = OdemeID;
                Fatura.EDITDATE = DateTime.Now;
                Fatura.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyon.TBL_IRSALIYELER Irsaliye = DB.TBL_IRSALIYELERs.First(s => s.ID == IrsaliyeID);
                Irsaliye.IRSALIYENO = txtIrsaliyeNo.Text;
                Irsaliye.TARIHI = DateTime.Parse(txtIrsaliyeTarihi.SelectedText);
                Irsaliye.EDITDATE = DateTime.Now;
                Irsaliye.EDITUSER = AnaForm.UserID;
                DB.TBL_STOKHAREKETLERIs.DeleteAllOnSubmit(DB.TBL_STOKHAREKETLERIs.Where(s => s.FATURAID == FaturaID));
                DB.SubmitChanges();
                Fonksiyon.TBL_STOKHAREKETLERI[] StokHareketi = new Fonksiyon.TBL_STOKHAREKETLERI[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    StokHareketi[i] = new Fonksiyon.TBL_STOKHAREKETLERI();
                    StokHareketi[i].FATURAID = FaturaID;
                    StokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    StokHareketi[i].GCKODU = "C";
                    StokHareketi[i].IRSALIYEID = IrsaliyeID;
                    StokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                    StokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    StokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
                    StokHareketi[i].TIPI = "Satış Faturası";
                    StokHareketi[i].SAVEDATE = DateTime.Now;
                    StokHareketi[i].SAVEUSER = AnaForm.UserID;
                    DB.TBL_STOKHAREKETLERIs.InsertOnSubmit(StokHareketi[i]);                  
                }
                DB.SubmitChanges();
                Fonksiyon.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == "Satış Faturası" && s.EVRAKID == FaturaID);
                if(txtFaturaTuru.SelectedIndex == 0)
                {
                    CariHareket.ALACAK = 0;
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                }
                else if(txtFaturaTuru.SelectedIndex == 1)
                {
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                    CariHareket.ALACAK = decimal.Parse(txtGenelToplam.Text);
                }
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && FaturaID > 0) FaturaGuncelle();
            else YeniFaturaKaydet();
        }

        private void txtOdemeYeri_EnabledChanged(object sender, EventArgs e)
        {
            if (txtOdemeYeri.Enabled)
            {
                OdemeYeri = txtOdemeYeri.Text;
            }
            else if (!txtOdemeYeri.Enabled)
            {
                OdemeYeri = "";
            }
        }
    }
}