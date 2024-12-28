namespace MuhasebeProgramı.Modul_Fatura
{
    partial class frmFaturaListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFaturaTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBarkod = new DevExpress.XtraEditors.DateEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURATURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kaybolanid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kaybolanstokkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagTikYenile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1686, 927);
            this.splitContainerControl1.SplitterPosition = 314;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(309, 927);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtFaturaNo);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtFaturaTuru);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(307, 892);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::MuhasebeProgramı.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(146, 242);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 60);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::MuhasebeProgramı.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(12, 242);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(128, 60);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tarih";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(11, 125);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(254, 26);
            this.txtFaturaNo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fatura No";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü";
            // 
            // txtFaturaTuru
            // 
            this.txtFaturaTuru.EditValue = "Satış Faturası";
            this.txtFaturaTuru.Location = new System.Drawing.Point(11, 59);
            this.txtFaturaTuru.Name = "txtFaturaTuru";
            this.txtFaturaTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaTuru.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txtFaturaTuru.Properties.ReadOnly = true;
            this.txtFaturaTuru.Size = new System.Drawing.Size(254, 26);
            this.txtFaturaTuru.TabIndex = 1;
            this.txtFaturaTuru.SelectedIndexChanged += new System.EventHandler(this.txtFaturaTuru_SelectedIndexChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.EditValue = null;
            this.txtBarkod.Location = new System.Drawing.Point(11, 191);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBarkod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBarkod.Properties.DisplayFormat.FormatString = "";
            this.txtBarkod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtBarkod.Properties.EditFormat.FormatString = "";
            this.txtBarkod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtBarkod.Properties.Mask.EditMask = "";
            this.txtBarkod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtBarkod.Size = new System.Drawing.Size(254, 26);
            this.txtBarkod.TabIndex = 5;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.ContextMenuStrip = this.SagTik;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1357, 927);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FATURANO,
            this.FATURATURU,
            this.CARIKODU});
            this.gridView1.DetailHeight = 512;
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.Width = 112;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "Fatura Numarası";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.MinWidth = 30;
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 0;
            this.FATURANO.Width = 112;
            // 
            // FATURATURU
            // 
            this.FATURATURU.Caption = "Fatura Türü";
            this.FATURATURU.FieldName = "FATURATURU";
            this.FATURATURU.MinWidth = 30;
            this.FATURATURU.Name = "FATURATURU";
            this.FATURATURU.OptionsColumn.AllowEdit = false;
            this.FATURATURU.OptionsColumn.AllowFocus = false;
            this.FATURATURU.OptionsColumn.FixedWidth = true;
            this.FATURATURU.Visible = true;
            this.FATURATURU.VisibleIndex = 1;
            this.FATURATURU.Width = 112;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "Cari Kodu";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.MinWidth = 30;
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 2;
            this.CARIKODU.Width = 112;
            // 
            // kaybolanid
            // 
            this.kaybolanid.Caption = "ID";
            this.kaybolanid.FieldName = "kaybolanid";
            this.kaybolanid.MinWidth = 30;
            this.kaybolanid.Name = "kaybolanid";
            this.kaybolanid.Width = 112;
            // 
            // kaybolanstokkodu
            // 
            this.kaybolanstokkodu.Caption = "STOKKODU";
            this.kaybolanstokkodu.FieldName = "kaybolanstokkodu";
            this.kaybolanstokkodu.MinWidth = 30;
            this.kaybolanstokkodu.Name = "kaybolanstokkodu";
            this.kaybolanstokkodu.OptionsColumn.AllowEdit = false;
            this.kaybolanstokkodu.OptionsColumn.AllowFocus = false;
            this.kaybolanstokkodu.OptionsColumn.FixedWidth = true;
            this.kaybolanstokkodu.Visible = true;
            this.kaybolanstokkodu.VisibleIndex = 0;
            this.kaybolanstokkodu.Width = 112;
            // 
            // SagTik
            // 
            this.SagTik.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagTikYenile});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(129, 36);
            // 
            // SagTikYenile
            // 
            this.SagTikYenile.Name = "SagTikYenile";
            this.SagTikYenile.Size = new System.Drawing.Size(128, 32);
            this.SagTikYenile.Text = "Yenile";
            this.SagTikYenile.Click += new System.EventHandler(this.SagTikYenile_Click);
            // 
            // frmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 927);
            this.ContextMenuStrip = this.SagTik;
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmFaturaListesi.IconOptions.Icon")));
            this.Name = "frmFaturaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.frmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtFaturaTuru;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn FATURATURU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn kaybolanid;
        private DevExpress.XtraGrid.Columns.GridColumn kaybolanstokkodu;
        private DevExpress.XtraEditors.DateEdit txtBarkod;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem SagTikYenile;
    }
}