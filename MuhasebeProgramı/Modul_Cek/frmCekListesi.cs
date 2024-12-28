using DevExpress.XtraEditors;
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

namespace MuhasebeProgramı.Modul_Cek
{
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();


        public bool Secim = false;
        int SecilenID = -1;
        public frmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CEKLERs
                      where s.TIPI.Contains(txtCekTuru.Text) && s.BANKA.Contains(txtBanka.Text) && s.CEKNO.Contains(txtCekNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecilenID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception )
            {
               
            }
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecilenID > 0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}