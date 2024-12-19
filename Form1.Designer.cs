using System;
using System.Windows.Forms;
namespace PetrolOtomasyonSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstSubeler;
        private System.Windows.Forms.ListBox lstPompalar;
        private System.Windows.Forms.ComboBox cmbPompaTipi;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtPompaAdi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.Button btnPompaEkle;
        private System.Windows.Forms.Button btnIslemKaydet;
        private System.Windows.Forms.Button btnIslemTemizle;
        private System.Windows.Forms.Button btnGunSonu;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.Label lblToplamSatis;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstSubeler = new System.Windows.Forms.ListBox();
            this.lstPompalar = new System.Windows.Forms.ListBox();
            this.cmbPompaTipi = new System.Windows.Forms.ComboBox();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtPompaAdi = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.btnPompaEkle = new System.Windows.Forms.Button();
            this.btnIslemKaydet = new System.Windows.Forms.Button();
            this.btnIslemTemizle = new System.Windows.Forms.Button();
            this.btnGunSonu = new System.Windows.Forms.Button();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblPompaAdi = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.petrolOtomasyonDBDataSet = new petroll.PetrolOtomasyonDBDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new petroll.PetrolOtomasyonDBDataSetTableAdapters.SalesTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSubeler
            // 
            this.lstSubeler.FormattingEnabled = true;
            this.lstSubeler.Location = new System.Drawing.Point(12, 12);
            this.lstSubeler.Name = "lstSubeler";
            this.lstSubeler.Size = new System.Drawing.Size(120, 95);
            this.lstSubeler.TabIndex = 0;
            // 
            // lstPompalar
            // 
            this.lstPompalar.FormattingEnabled = true;
            this.lstPompalar.Location = new System.Drawing.Point(12, 113);
            this.lstPompalar.Name = "lstPompalar";
            this.lstPompalar.Size = new System.Drawing.Size(120, 95);
            this.lstPompalar.TabIndex = 1;
            // 
            // cmbPompaTipi
            // 
            this.cmbPompaTipi.FormattingEnabled = true;
            this.cmbPompaTipi.Location = new System.Drawing.Point(158, 12);
            this.cmbPompaTipi.Name = "cmbPompaTipi";
            this.cmbPompaTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbPompaTipi.TabIndex = 2;
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Location = new System.Drawing.Point(158, 39);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbOdemeTuru.TabIndex = 3;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(158, 66);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(121, 20);
            this.txtSubeAdi.TabIndex = 4;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(158, 92);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(121, 20);
            this.txtIl.TabIndex = 5;
            // 
            // txtPompaAdi
            // 
            this.txtPompaAdi.Location = new System.Drawing.Point(158, 119);
            this.txtPompaAdi.Name = "txtPompaAdi";
            this.txtPompaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtPompaAdi.TabIndex = 6;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(158, 145);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 20);
            this.txtPlaka.TabIndex = 7;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(158, 171);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 20);
            this.txtMiktar.TabIndex = 8;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(158, 197);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 20);
            this.txtTutar.TabIndex = 9;
            // 
            // btnSubeEkle
            // 
            this.btnSubeEkle.Location = new System.Drawing.Point(158, 223);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Size = new System.Drawing.Size(121, 23);
            this.btnSubeEkle.TabIndex = 10;
            this.btnSubeEkle.Text = "Şube Ekle";
            this.btnSubeEkle.UseVisualStyleBackColor = true;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
            // 
            // btnPompaEkle
            // 
            this.btnPompaEkle.Location = new System.Drawing.Point(158, 252);
            this.btnPompaEkle.Name = "btnPompaEkle";
            this.btnPompaEkle.Size = new System.Drawing.Size(121, 23);
            this.btnPompaEkle.TabIndex = 11;
            this.btnPompaEkle.Text = "Pompa Ekle";
            this.btnPompaEkle.UseVisualStyleBackColor = true;
            this.btnPompaEkle.Click += new System.EventHandler(this.btnPompaEkle_Click);
            // 
            // btnIslemKaydet
            // 
            this.btnIslemKaydet.Location = new System.Drawing.Point(158, 281);
            this.btnIslemKaydet.Name = "btnIslemKaydet";
            this.btnIslemKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnIslemKaydet.TabIndex = 12;
            this.btnIslemKaydet.Text = "Ödeme Kaydet";
            this.btnIslemKaydet.UseVisualStyleBackColor = true;
            this.btnIslemKaydet.Click += new System.EventHandler(this.btnIslemKaydet_Click);
            // 
            // btnIslemTemizle
            // 
            this.btnIslemTemizle.Location = new System.Drawing.Point(158, 310);
            this.btnIslemTemizle.Name = "btnIslemTemizle";
            this.btnIslemTemizle.Size = new System.Drawing.Size(121, 23);
            this.btnIslemTemizle.TabIndex = 13;
            this.btnIslemTemizle.Text = "Temizle";
            this.btnIslemTemizle.UseVisualStyleBackColor = true;
            this.btnIslemTemizle.Click += new System.EventHandler(this.btnIslemTemizle_Click);
            // 
            // btnGunSonu
            // 
            this.btnGunSonu.Location = new System.Drawing.Point(158, 339);
            this.btnGunSonu.Name = "btnGunSonu";
            this.btnGunSonu.Size = new System.Drawing.Size(121, 23);
            this.btnGunSonu.TabIndex = 14;
            this.btnGunSonu.Text = "Gün Sonu";
            this.btnGunSonu.UseVisualStyleBackColor = true;
            this.btnGunSonu.Click += new System.EventHandler(this.btnGunSonu_Click);
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.AutoGenerateColumns = false;
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.pumpNumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.branchNameDataGridViewTextBoxColumn,
            this.litersDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvIslemler.DataSource = this.salesBindingSource;
            this.dgvIslemler.Location = new System.Drawing.Point(12, 223);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.Size = new System.Drawing.Size(120, 150);
            this.dgvIslemler.TabIndex = 15;
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(12, 380);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(71, 13);
            this.lblToplamSatis.TabIndex = 16;
            this.lblToplamSatis.Text = "Toplam Satış:";
            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(316, 72);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(47, 13);
            this.lblSubeAdi.TabIndex = 17;
            this.lblSubeAdi.Text = "ŞubeAdı";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Location = new System.Drawing.Point(319, 98);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(12, 13);
            this.lblIl.TabIndex = 18;
            this.lblIl.Text = "İl";
            // 
            // lblPompaAdi
            // 
            this.lblPompaAdi.AutoSize = true;
            this.lblPompaAdi.Location = new System.Drawing.Point(319, 125);
            this.lblPompaAdi.Name = "lblPompaAdi";
            this.lblPompaAdi.Size = new System.Drawing.Size(55, 13);
            this.lblPompaAdi.TabIndex = 19;
            this.lblPompaAdi.Text = "PompaAdı";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(319, 151);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 20;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(319, 177);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 21;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(319, 203);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(32, 13);
            this.lblTutar.TabIndex = 22;
            this.lblTutar.Text = "Tutar";
            // 
            // petrolOtomasyonDBDataSet
            // 
            this.petrolOtomasyonDBDataSet.DataSetName = "PetrolOtomasyonDBDataSet";
            this.petrolOtomasyonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.petrolOtomasyonDBDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pumpNumberDataGridViewTextBoxColumn
            // 
            this.pumpNumberDataGridViewTextBoxColumn.DataPropertyName = "PumpNumber";
            this.pumpNumberDataGridViewTextBoxColumn.HeaderText = "PumpNumber";
            this.pumpNumberDataGridViewTextBoxColumn.Name = "pumpNumberDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "BranchName";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "BranchName";
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            // 
            // litersDataGridViewTextBoxColumn
            // 
            this.litersDataGridViewTextBoxColumn.DataPropertyName = "Liters";
            this.litersDataGridViewTextBoxColumn.HeaderText = "Liters";
            this.litersDataGridViewTextBoxColumn.Name = "litersDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 804);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblPompaAdi);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.dgvIslemler);
            this.Controls.Add(this.btnGunSonu);
            this.Controls.Add(this.btnIslemTemizle);
            this.Controls.Add(this.btnIslemKaydet);
            this.Controls.Add(this.btnPompaEkle);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtPompaAdi);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.cmbPompaTipi);
            this.Controls.Add(this.lstPompalar);
            this.Controls.Add(this.lstSubeler);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Petrol Otomasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblSubeAdi;
        private Label lblIl;
        private Label lblPompaAdi;
        private Label lblPlaka;
        private Label lblMiktar;
        private Label lblTutar;
        private petroll.PetrolOtomasyonDBDataSet petrolOtomasyonDBDataSet;
        private BindingSource salesBindingSource;
        private petroll.PetrolOtomasyonDBDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pumpNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn litersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
