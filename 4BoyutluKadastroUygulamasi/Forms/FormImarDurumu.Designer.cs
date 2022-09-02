
namespace _4BoyutluKadastroUygulamasi.Forms
{
    partial class FormImarDurumu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImarDurumu));
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
      this.txtTapuAlani = new DevExpress.XtraEditors.TextEdit();
      this.txtParsel = new DevExpress.XtraEditors.TextEdit();
      this.txtAda = new DevExpress.XtraEditors.TextEdit();
      this.txtId = new DevExpress.XtraEditors.TextEdit();
      this.btnTemizle = new System.Windows.Forms.Button();
      this.btnGuncelle = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.lblImarDurumu = new System.Windows.Forms.Label();
      this.lblAciklama = new System.Windows.Forms.Label();
      this.lblAda = new System.Windows.Forms.Label();
      this.lblParsel = new System.Windows.Forms.Label();
      this.lblTapuAlani = new System.Windows.Forms.Label();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
      this.txtResimYolu = new DevExpress.XtraEditors.TextEdit();
      this.lblResim = new System.Windows.Forms.Label();
      this.btnResimEkle = new System.Windows.Forms.Button();
      this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTapuAlani.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtResimYolu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // groupControl1
      // 
      this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupControl1.Controls.Add(this.txtResimYolu);
      this.groupControl1.Controls.Add(this.lblResim);
      this.groupControl1.Controls.Add(this.lookUpEdit1);
      this.groupControl1.Controls.Add(this.btnResimEkle);
      this.groupControl1.Controls.Add(this.txtTapuAlani);
      this.groupControl1.Controls.Add(this.txtParsel);
      this.groupControl1.Controls.Add(this.txtAda);
      this.groupControl1.Controls.Add(this.txtId);
      this.groupControl1.Controls.Add(this.btnTemizle);
      this.groupControl1.Controls.Add(this.btnGuncelle);
      this.groupControl1.Controls.Add(this.btnSil);
      this.groupControl1.Controls.Add(this.btnKaydet);
      this.groupControl1.Controls.Add(this.lblImarDurumu);
      this.groupControl1.Controls.Add(this.lblAciklama);
      this.groupControl1.Controls.Add(this.lblAda);
      this.groupControl1.Controls.Add(this.lblParsel);
      this.groupControl1.Controls.Add(this.lblTapuAlani);
      this.groupControl1.Controls.Add(this.txtAciklama);
      this.groupControl1.Location = new System.Drawing.Point(684, 12);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(308, 567);
      this.groupControl1.TabIndex = 3;
      this.groupControl1.Text = "İmar Durumu İşlemleri";
      // 
      // lookUpEdit1
      // 
      this.lookUpEdit1.Location = new System.Drawing.Point(115, 142);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit1.Properties.DisplayMember = "Aciklama";
      this.lookUpEdit1.Properties.NullText = "İmar durumu seçiniz...";
      this.lookUpEdit1.Properties.ValueMember = "Id";
      this.lookUpEdit1.Size = new System.Drawing.Size(172, 22);
      this.lookUpEdit1.TabIndex = 4;
      // 
      // txtTapuAlani
      // 
      this.txtTapuAlani.Location = new System.Drawing.Point(115, 114);
      this.txtTapuAlani.Name = "txtTapuAlani";
      this.txtTapuAlani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtTapuAlani.Properties.Appearance.Options.UseFont = true;
      this.txtTapuAlani.Size = new System.Drawing.Size(172, 22);
      this.txtTapuAlani.TabIndex = 3;
      this.txtTapuAlani.TextChanged += new System.EventHandler(this.txtTapuAlani_TextChanged);
      // 
      // txtParsel
      // 
      this.txtParsel.Location = new System.Drawing.Point(115, 86);
      this.txtParsel.Name = "txtParsel";
      this.txtParsel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtParsel.Properties.Appearance.Options.UseFont = true;
      this.txtParsel.Size = new System.Drawing.Size(172, 22);
      this.txtParsel.TabIndex = 2;
      this.txtParsel.TextChanged += new System.EventHandler(this.txtParsel_TextChanged);
      // 
      // txtAda
      // 
      this.txtAda.Location = new System.Drawing.Point(115, 58);
      this.txtAda.Name = "txtAda";
      this.txtAda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAda.Properties.Appearance.Options.UseFont = true;
      this.txtAda.Size = new System.Drawing.Size(172, 22);
      this.txtAda.TabIndex = 1;
      this.txtAda.TextChanged += new System.EventHandler(this.txtAda_TextChanged);
      // 
      // txtId
      // 
      this.txtId.Enabled = false;
      this.txtId.Location = new System.Drawing.Point(126, 26);
      this.txtId.Name = "txtId";
      this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtId.Properties.Appearance.Options.UseFont = true;
      this.txtId.Size = new System.Drawing.Size(153, 22);
      this.txtId.TabIndex = 0;
      this.txtId.Visible = false;
      // 
      // btnTemizle
      // 
      this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
      this.btnTemizle.FlatAppearance.BorderSize = 0;
      this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnTemizle.ForeColor = System.Drawing.Color.White;
      this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
      this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTemizle.Location = new System.Drawing.Point(141, 507);
      this.btnTemizle.Name = "btnTemizle";
      this.btnTemizle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnTemizle.Size = new System.Drawing.Size(120, 30);
      this.btnTemizle.TabIndex = 9;
      this.btnTemizle.Text = "Temizle";
      this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTemizle.UseVisualStyleBackColor = false;
      this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
      this.btnGuncelle.FlatAppearance.BorderSize = 0;
      this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGuncelle.ForeColor = System.Drawing.Color.White;
      this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
      this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnGuncelle.Location = new System.Drawing.Point(141, 461);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnGuncelle.Size = new System.Drawing.Size(120, 30);
      this.btnGuncelle.TabIndex = 8;
      this.btnGuncelle.Text = "Güncelle";
      this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnGuncelle.UseVisualStyleBackColor = false;
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
      this.btnSil.FlatAppearance.BorderSize = 0;
      this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSil.ForeColor = System.Drawing.Color.White;
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSil.Location = new System.Drawing.Point(141, 415);
      this.btnSil.Name = "btnSil";
      this.btnSil.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnSil.Size = new System.Drawing.Size(120, 30);
      this.btnSil.TabIndex = 7;
      this.btnSil.Text = "Sil";
      this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSil.UseVisualStyleBackColor = false;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
      this.btnKaydet.FlatAppearance.BorderSize = 0;
      this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKaydet.ForeColor = System.Drawing.Color.White;
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnKaydet.Location = new System.Drawing.Point(141, 369);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnKaydet.Size = new System.Drawing.Size(120, 30);
      this.btnKaydet.TabIndex = 6;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnKaydet.UseVisualStyleBackColor = false;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // lblImarDurumu
      // 
      this.lblImarDurumu.AutoSize = true;
      this.lblImarDurumu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblImarDurumu.Location = new System.Drawing.Point(14, 145);
      this.lblImarDurumu.Name = "lblImarDurumu";
      this.lblImarDurumu.Size = new System.Drawing.Size(93, 16);
      this.lblImarDurumu.TabIndex = 5;
      this.lblImarDurumu.Text = "İmar Durumu :";
      // 
      // lblAciklama
      // 
      this.lblAciklama.AutoSize = true;
      this.lblAciklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblAciklama.Location = new System.Drawing.Point(39, 172);
      this.lblAciklama.Name = "lblAciklama";
      this.lblAciklama.Size = new System.Drawing.Size(68, 16);
      this.lblAciklama.TabIndex = 4;
      this.lblAciklama.Text = "Açıklama :";
      // 
      // lblAda
      // 
      this.lblAda.AutoSize = true;
      this.lblAda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblAda.Location = new System.Drawing.Point(68, 61);
      this.lblAda.Name = "lblAda";
      this.lblAda.Size = new System.Drawing.Size(39, 16);
      this.lblAda.TabIndex = 3;
      this.lblAda.Text = "Ada :";
      // 
      // lblParsel
      // 
      this.lblParsel.AutoSize = true;
      this.lblParsel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblParsel.Location = new System.Drawing.Point(55, 89);
      this.lblParsel.Name = "lblParsel";
      this.lblParsel.Size = new System.Drawing.Size(52, 16);
      this.lblParsel.TabIndex = 2;
      this.lblParsel.Text = "Parsel :";
      // 
      // lblTapuAlani
      // 
      this.lblTapuAlani.AutoSize = true;
      this.lblTapuAlani.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblTapuAlani.Location = new System.Drawing.Point(29, 117);
      this.lblTapuAlani.Name = "lblTapuAlani";
      this.lblTapuAlani.Size = new System.Drawing.Size(78, 16);
      this.lblTapuAlani.TabIndex = 1;
      this.lblTapuAlani.Text = "Tapu Alanı :";
      // 
      // gridControl1
      // 
      this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.gridControl1.Location = new System.Drawing.Point(12, 12);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(650, 567);
      this.gridControl1.TabIndex = 6;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.SteelBlue;
      this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.MediumTurquoise;
      this.gridView1.Appearance.Row.Options.UseBackColor = true;
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
      this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
      this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // errorProvider2
      // 
      this.errorProvider2.ContainerControl = this;
      // 
      // errorProvider3
      // 
      this.errorProvider3.ContainerControl = this;
      // 
      // txtResimYolu
      // 
      this.txtResimYolu.Location = new System.Drawing.Point(115, 265);
      this.txtResimYolu.Name = "txtResimYolu";
      this.txtResimYolu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtResimYolu.Properties.Appearance.Options.UseFont = true;
      this.txtResimYolu.Size = new System.Drawing.Size(172, 22);
      this.txtResimYolu.TabIndex = 13;
      // 
      // lblResim
      // 
      this.lblResim.AutoSize = true;
      this.lblResim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblResim.Location = new System.Drawing.Point(55, 268);
      this.lblResim.Name = "lblResim";
      this.lblResim.Size = new System.Drawing.Size(52, 16);
      this.lblResim.TabIndex = 15;
      this.lblResim.Text = "Resim :";
      // 
      // btnResimEkle
      // 
      this.btnResimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
      this.btnResimEkle.FlatAppearance.BorderSize = 0;
      this.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnResimEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnResimEkle.ForeColor = System.Drawing.Color.White;
      this.btnResimEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.Image")));
      this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnResimEkle.Location = new System.Drawing.Point(141, 323);
      this.btnResimEkle.Name = "btnResimEkle";
      this.btnResimEkle.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
      this.btnResimEkle.Size = new System.Drawing.Size(120, 30);
      this.btnResimEkle.TabIndex = 14;
      this.btnResimEkle.Text = "Resim Ekle";
      this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnResimEkle.UseVisualStyleBackColor = false;
      this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
      // 
      // txtAciklama
      // 
      this.txtAciklama.Location = new System.Drawing.Point(115, 170);
      this.txtAciklama.Name = "txtAciklama";
      this.txtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAciklama.Properties.Appearance.Options.UseFont = true;
      this.txtAciklama.Size = new System.Drawing.Size(172, 89);
      this.txtAciklama.TabIndex = 5;
      // 
      // FormImarDurumu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1004, 591);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.gridControl1);
      this.Name = "FormImarDurumu";
      this.Text = "İmar Durumu";
      this.Load += new System.EventHandler(this.FormImarDurumu_Load);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTapuAlani.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtResimYolu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTapuAlani;
        private DevExpress.XtraEditors.TextEdit txtParsel;
        private DevExpress.XtraEditors.TextEdit txtAda;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblImarDurumu;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblAda;
        private System.Windows.Forms.Label lblParsel;
        private System.Windows.Forms.Label lblTapuAlani;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    public DevExpress.XtraEditors.TextEdit txtResimYolu;
    private System.Windows.Forms.Label lblResim;
    private System.Windows.Forms.Button btnResimEkle;
    private DevExpress.XtraEditors.MemoEdit txtAciklama;
  }
}