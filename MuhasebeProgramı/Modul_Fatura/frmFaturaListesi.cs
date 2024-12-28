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

namespace MuhasebeProgramı.Modul_Fatura
{
    public partial class frmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyon.DataClasses1DataContext DB = new Fonksiyon.DataClasses1DataContext();
        Fonksiyon.Formlar Formlar = new Fonksiyon.Formlar();
        bool Secimn = false;

        public frmFaturaListesi(bool Secim)
        {
            InitializeComponent();
            Secimn = Secim;
        }

        private void frmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_FATURALARs
                      where s.FATURATURU.Contains(txtFaturaTuru.Text) && s.FATURANO.Contains(txtFaturaNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void txtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            if ( ID > 0)
            {
                Formlar.Fatura(true, ID, false);
            }
        }

        private void SagTikYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}