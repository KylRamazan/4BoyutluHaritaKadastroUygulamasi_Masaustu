
namespace _4BoyutluKadastroUygulamasi.Forms
{
    partial class Form3D
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3D));
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
      this.txtKotFarki = new DevExpress.XtraEditors.TextEdit();
      this.txtTescilNesneKotu = new DevExpress.XtraEditors.TextEdit();
      this.txtParselinOrtKotu = new DevExpress.XtraEditors.TextEdit();
      this.txtParsel = new DevExpress.XtraEditors.TextEdit();
      this.txtAda = new DevExpress.XtraEditors.TextEdit();
      this.txtId = new DevExpress.XtraEditors.TextEdit();
      this.lblKotFarki = new System.Windows.Forms.Label();
      this.btnTemizle = new System.Windows.Forms.Button();
      this.btnGuncelle = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.lblTescilNesneTipi = new System.Windows.Forms.Label();
      this.lblTescilNesneKotu = new System.Windows.Forms.Label();
      this.lblAda = new System.Windows.Forms.Label();
      this.lblParsel = new System.Windows.Forms.Label();
      this.lblParselinOrtKotu = new System.Windows.Forms.Label();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKotFarki.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTescilNesneKotu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParselinOrtKotu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
      this.SuspendLayout();
      // 
      // groupControl1
      // 
      this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupControl1.Controls.Add(this.lookUpEdit1);
      this.groupControl1.Controls.Add(this.txtKotFarki);
      this.groupControl1.Controls.Add(this.txtTescilNesneKotu);
      this.groupControl1.Controls.Add(this.txtParselinOrtKotu);
      this.groupControl1.Controls.Add(this.txtParsel);
      this.groupControl1.Controls.Add(this.txtAda);
      this.groupControl1.Controls.Add(this.txtId);
      this.groupControl1.Controls.Add(this.lblKotFarki);
      this.groupControl1.Controls.Add(this.btnTemizle);
      this.groupControl1.Controls.Add(this.btnGuncelle);
      this.groupControl1.Controls.Add(this.btnSil);
      this.groupControl1.Controls.Add(this.btnKaydet);
      this.groupControl1.Controls.Add(this.lblTescilNesneTipi);
      this.groupControl1.Controls.Add(this.lblTescilNesneKotu);
      this.groupControl1.Controls.Add(this.lblAda);
      this.groupControl1.Controls.Add(this.lblParsel);
      this.groupControl1.Controls.Add(this.lblParselinOrtKotu);
      this.groupControl1.Location = new System.Drawing.Point(686, 12);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(306, 567);
      this.groupControl1.TabIndex = 3;
      this.groupControl1.Text = "3D İşlemleri";
      // 
      // lookUpEdit1
      // 
      this.lookUpEdit1.Location = new System.Drawing.Point(137, 171);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit1.Properties.DisplayMember = "NesneTipi";
      this.lookUpEdit1.Properties.NullText = "Nesne tipi seçiniz...";
      this.lookUpEdit1.Properties.ValueMember = "Id";
      this.lookUpEdit1.Size = new System.Drawing.Size(149, 22);
      this.lookUpEdit1.TabIndex = 4;
      // 
      // txtKotFarki
      // 
      this.txtKotFarki.Location = new System.Drawing.Point(137, 237);
      this.txtKotFarki.Name = "txtKotFarki";
      this.txtKotFarki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtKotFarki.Properties.Appearance.Options.UseFont = true;
      this.txtKotFarki.Size = new System.Drawing.Size(149, 22);
      this.txtKotFarki.TabIndex = 6;
      this.txtKotFarki.TextChanged += new System.EventHandler(this.txtKotFarki_TextChanged);
      // 
      // txtTescilNesneKotu
      // 
      this.txtTescilNesneKotu.Location = new System.Drawing.Point(137, 204);
      this.txtTescilNesneKotu.Name = "txtTescilNesneKotu";
      this.txtTescilNesneKotu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtTescilNesneKotu.Properties.Appearance.Options.UseFont = true;
      this.txtTescilNesneKotu.Size = new System.Drawing.Size(149, 22);
      this.txtTescilNesneKotu.TabIndex = 5;
      this.txtTescilNesneKotu.TextChanged += new System.EventHandler(this.txtTescilNesneKotu_TextChanged);
      // 
      // txtParselinOrtKotu
      // 
      this.txtParselinOrtKotu.Location = new System.Drawing.Point(137, 138);
      this.txtParselinOrtKotu.Name = "txtParselinOrtKotu";
      this.txtParselinOrtKotu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtParselinOrtKotu.Properties.Appearance.Options.UseFont = true;
      this.txtParselinOrtKotu.Size = new System.Drawing.Size(149, 22);
      this.txtParselinOrtKotu.TabIndex = 3;
      this.txtParselinOrtKotu.TextChanged += new System.EventHandler(this.txtParselinOrtKotu_TextChanged);
      // 
      // txtParsel
      // 
      this.txtParsel.Location = new System.Drawing.Point(137, 105);
      this.txtParsel.Name = "txtParsel";
      this.txtParsel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtParsel.Properties.Appearance.Options.UseFont = true;
      this.txtParsel.Size = new System.Drawing.Size(149, 22);
      this.txtParsel.TabIndex = 2;
      this.txtParsel.TextChanged += new System.EventHandler(this.txtParsel_TextChanged);
      // 
      // txtAda
      // 
      this.txtAda.Location = new System.Drawing.Point(137, 72);
      this.txtAda.Name = "txtAda";
      this.txtAda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAda.Properties.Appearance.Options.UseFont = true;
      this.txtAda.Size = new System.Drawing.Size(149, 22);
      this.txtAda.TabIndex = 1;
      this.txtAda.TextChanged += new System.EventHandler(this.txtAda_TextChanged);
      // 
      // txtId
      // 
      this.txtId.Enabled = false;
      this.txtId.Location = new System.Drawing.Point(131, 26);
      this.txtId.Name = "txtId";
      this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtId.Properties.Appearance.Options.UseFont = true;
      this.txtId.Size = new System.Drawing.Size(149, 22);
      this.txtId.TabIndex = 0;
      this.txtId.Visible = false;
      // 
      // lblKotFarki
      // 
      this.lblKotFarki.AutoSize = true;
      this.lblKotFarki.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblKotFarki.Location = new System.Drawing.Point(64, 240);
      this.lblKotFarki.Name = "lblKotFarki";
      this.lblKotFarki.Size = new System.Drawing.Size(67, 16);
      this.lblKotFarki.TabIndex = 11;
      this.lblKotFarki.Text = "Kot Farkı :";
      // 
      // btnTemizle
      // 
      this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
      this.btnTemizle.FlatAppearance.BorderSize = 0;
      this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnTemizle.ForeColor = System.Drawing.Color.White;
      this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
      this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTemizle.Location = new System.Drawing.Point(151, 462);
      this.btnTemizle.Name = "btnTemizle";
      this.btnTemizle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnTemizle.Size = new System.Drawing.Size(120, 30);
      this.btnTemizle.TabIndex = 10;
      this.btnTemizle.Text = "Temizle";
      this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTemizle.UseVisualStyleBackColor = false;
      this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
      this.btnGuncelle.FlatAppearance.BorderSize = 0;
      this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGuncelle.ForeColor = System.Drawing.Color.White;
      this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
      this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnGuncelle.Location = new System.Drawing.Point(151, 416);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnGuncelle.Size = new System.Drawing.Size(120, 30);
      this.btnGuncelle.TabIndex = 9;
      this.btnGuncelle.Text = "Güncelle";
      this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnGuncelle.UseVisualStyleBackColor = false;
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
      this.btnSil.FlatAppearance.BorderSize = 0;
      this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSil.ForeColor = System.Drawing.Color.White;
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSil.Location = new System.Drawing.Point(151, 370);
      this.btnSil.Name = "btnSil";
      this.btnSil.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnSil.Size = new System.Drawing.Size(120, 30);
      this.btnSil.TabIndex = 8;
      this.btnSil.Text = "Sil";
      this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSil.UseVisualStyleBackColor = false;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
      this.btnKaydet.FlatAppearance.BorderSize = 0;
      this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKaydet.ForeColor = System.Drawing.Color.White;
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnKaydet.Location = new System.Drawing.Point(151, 324);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnKaydet.Size = new System.Drawing.Size(120, 30);
      this.btnKaydet.TabIndex = 7;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnKaydet.UseVisualStyleBackColor = false;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // lblTescilNesneTipi
      // 
      this.lblTescilNesneTipi.AutoSize = true;
      this.lblTescilNesneTipi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblTescilNesneTipi.Location = new System.Drawing.Point(17, 174);
      this.lblTescilNesneTipi.Name = "lblTescilNesneTipi";
      this.lblTescilNesneTipi.Size = new System.Drawing.Size(114, 16);
      this.lblTescilNesneTipi.TabIndex = 5;
      this.lblTescilNesneTipi.Text = "Tescil Nesne Tipi :";
      // 
      // lblTescilNesneKotu
      // 
      this.lblTescilNesneKotu.AutoSize = true;
      this.lblTescilNesneKotu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblTescilNesneKotu.Location = new System.Drawing.Point(13, 207);
      this.lblTescilNesneKotu.Name = "lblTescilNesneKotu";
      this.lblTescilNesneKotu.Size = new System.Drawing.Size(118, 16);
      this.lblTescilNesneKotu.TabIndex = 4;
      this.lblTescilNesneKotu.Text = "Tescil Nesne Kotu :";
      // 
      // lblAda
      // 
      this.lblAda.AutoSize = true;
      this.lblAda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblAda.Location = new System.Drawing.Point(92, 75);
      this.lblAda.Name = "lblAda";
      this.lblAda.Size = new System.Drawing.Size(39, 16);
      this.lblAda.TabIndex = 3;
      this.lblAda.Text = "Ada :";
      // 
      // lblParsel
      // 
      this.lblParsel.AutoSize = true;
      this.lblParsel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblParsel.Location = new System.Drawing.Point(79, 108);
      this.lblParsel.Name = "lblParsel";
      this.lblParsel.Size = new System.Drawing.Size(52, 16);
      this.lblParsel.TabIndex = 2;
      this.lblParsel.Text = "Parsel :";
      // 
      // lblParselinOrtKotu
      // 
      this.lblParselinOrtKotu.AutoSize = true;
      this.lblParselinOrtKotu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblParselinOrtKotu.Location = new System.Drawing.Point(14, 141);
      this.lblParselinOrtKotu.Name = "lblParselinOrtKotu";
      this.lblParselinOrtKotu.Size = new System.Drawing.Size(117, 16);
      this.lblParselinOrtKotu.TabIndex = 1;
      this.lblParselinOrtKotu.Text = "Parselin Ort. Kotu :";
      // 
      // gridControl1
      // 
      this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.gridControl1.Location = new System.Drawing.Point(12, 12);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(654, 567);
      this.gridControl1.TabIndex = 2;
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
      // errorProvider4
      // 
      this.errorProvider4.ContainerControl = this;
      // 
      // errorProvider5
      // 
      this.errorProvider5.ContainerControl = this;
      // 
      // errorProvider6
      // 
      this.errorProvider6.ContainerControl = this;
      // 
      // Form3D
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1004, 591);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.gridControl1);
      this.Name = "Form3D";
      this.Text = "3D";
      this.Load += new System.EventHandler(this.Form3D_Load);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKotFarki.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTescilNesneKotu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParselinOrtKotu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblTescilNesneTipi;
        private System.Windows.Forms.Label lblTescilNesneKotu;
        private System.Windows.Forms.Label lblAda;
        private System.Windows.Forms.Label lblParsel;
        private System.Windows.Forms.Label lblParselinOrtKotu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblKotFarki;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtKotFarki;
        private DevExpress.XtraEditors.TextEdit txtTescilNesneKotu;
        private DevExpress.XtraEditors.TextEdit txtParselinOrtKotu;
        private DevExpress.XtraEditors.TextEdit txtParsel;
        private DevExpress.XtraEditors.TextEdit txtAda;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}