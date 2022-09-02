
namespace _4BoyutluKadastroUygulamasi.Forms
{
    partial class Form2D
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2D));
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.txtResimYolu = new DevExpress.XtraEditors.TextEdit();
      this.lblResim = new System.Windows.Forms.Label();
      this.btnResimEkle = new System.Windows.Forms.Button();
      this.btnTemizle = new System.Windows.Forms.Button();
      this.btnGuncelle = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.txtX = new DevExpress.XtraEditors.TextEdit();
      this.txtY = new DevExpress.XtraEditors.TextEdit();
      this.txtNoktaNo = new DevExpress.XtraEditors.TextEdit();
      this.txtParsel = new DevExpress.XtraEditors.TextEdit();
      this.txtAda = new DevExpress.XtraEditors.TextEdit();
      this.txtId = new DevExpress.XtraEditors.TextEdit();
      this.lblY = new System.Windows.Forms.Label();
      this.lblX = new System.Windows.Forms.Label();
      this.lblAda = new System.Windows.Forms.Label();
      this.lblParsel = new System.Windows.Forms.Label();
      this.lblNoktaNo = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtResimYolu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtX.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtY.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNoktaNo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.gridControl1.Location = new System.Drawing.Point(12, 12);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(657, 567);
      this.gridControl1.TabIndex = 0;
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
      // groupControl1
      // 
      this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupControl1.Controls.Add(this.txtResimYolu);
      this.groupControl1.Controls.Add(this.lblResim);
      this.groupControl1.Controls.Add(this.btnResimEkle);
      this.groupControl1.Controls.Add(this.btnTemizle);
      this.groupControl1.Controls.Add(this.btnGuncelle);
      this.groupControl1.Controls.Add(this.btnSil);
      this.groupControl1.Controls.Add(this.btnKaydet);
      this.groupControl1.Controls.Add(this.txtX);
      this.groupControl1.Controls.Add(this.txtY);
      this.groupControl1.Controls.Add(this.txtNoktaNo);
      this.groupControl1.Controls.Add(this.txtParsel);
      this.groupControl1.Controls.Add(this.txtAda);
      this.groupControl1.Controls.Add(this.txtId);
      this.groupControl1.Controls.Add(this.lblY);
      this.groupControl1.Controls.Add(this.lblX);
      this.groupControl1.Controls.Add(this.lblAda);
      this.groupControl1.Controls.Add(this.lblParsel);
      this.groupControl1.Controls.Add(this.lblNoktaNo);
      this.groupControl1.Location = new System.Drawing.Point(691, 12);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(301, 567);
      this.groupControl1.TabIndex = 1;
      this.groupControl1.Text = "2D İşlemleri";
      // 
      // txtResimYolu
      // 
      this.txtResimYolu.Location = new System.Drawing.Point(94, 240);
      this.txtResimYolu.Name = "txtResimYolu";
      this.txtResimYolu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtResimYolu.Properties.Appearance.Options.UseFont = true;
      this.txtResimYolu.Size = new System.Drawing.Size(188, 22);
      this.txtResimYolu.TabIndex = 6;
      this.txtResimYolu.EditValueChanged += new System.EventHandler(this.txtResimYolu_EditValueChanged);
      // 
      // lblResim
      // 
      this.lblResim.AutoSize = true;
      this.lblResim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblResim.Location = new System.Drawing.Point(36, 243);
      this.lblResim.Name = "lblResim";
      this.lblResim.Size = new System.Drawing.Size(52, 16);
      this.lblResim.TabIndex = 12;
      this.lblResim.Text = "Resim :";
      this.lblResim.Click += new System.EventHandler(this.lblResim_Click);
      // 
      // btnResimEkle
      // 
      this.btnResimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
      this.btnResimEkle.FlatAppearance.BorderSize = 0;
      this.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnResimEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnResimEkle.ForeColor = System.Drawing.Color.White;
      this.btnResimEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.Image")));
      this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnResimEkle.Location = new System.Drawing.Point(126, 310);
      this.btnResimEkle.Name = "btnResimEkle";
      this.btnResimEkle.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
      this.btnResimEkle.Size = new System.Drawing.Size(120, 30);
      this.btnResimEkle.TabIndex = 7;
      this.btnResimEkle.Text = "Resim Ekle";
      this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnResimEkle.UseVisualStyleBackColor = false;
      this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
      // 
      // btnTemizle
      // 
      this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
      this.btnTemizle.FlatAppearance.BorderSize = 0;
      this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnTemizle.ForeColor = System.Drawing.Color.White;
      this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
      this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTemizle.Location = new System.Drawing.Point(126, 494);
      this.btnTemizle.Name = "btnTemizle";
      this.btnTemizle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnTemizle.Size = new System.Drawing.Size(120, 30);
      this.btnTemizle.TabIndex = 11;
      this.btnTemizle.Text = "Temizle";
      this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTemizle.UseVisualStyleBackColor = false;
      this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
      this.btnGuncelle.FlatAppearance.BorderSize = 0;
      this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGuncelle.ForeColor = System.Drawing.Color.White;
      this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
      this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnGuncelle.Location = new System.Drawing.Point(126, 448);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnGuncelle.Size = new System.Drawing.Size(120, 30);
      this.btnGuncelle.TabIndex = 10;
      this.btnGuncelle.Text = "Güncelle";
      this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnGuncelle.UseVisualStyleBackColor = false;
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
      this.btnSil.FlatAppearance.BorderSize = 0;
      this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSil.ForeColor = System.Drawing.Color.White;
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSil.Location = new System.Drawing.Point(126, 402);
      this.btnSil.Name = "btnSil";
      this.btnSil.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnSil.Size = new System.Drawing.Size(120, 30);
      this.btnSil.TabIndex = 9;
      this.btnSil.Text = "Sil";
      this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSil.UseVisualStyleBackColor = false;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
      this.btnKaydet.FlatAppearance.BorderSize = 0;
      this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKaydet.ForeColor = System.Drawing.Color.White;
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnKaydet.Location = new System.Drawing.Point(126, 356);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
      this.btnKaydet.Size = new System.Drawing.Size(120, 30);
      this.btnKaydet.TabIndex = 8;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnKaydet.UseVisualStyleBackColor = false;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // txtX
      // 
      this.txtX.Location = new System.Drawing.Point(94, 207);
      this.txtX.Name = "txtX";
      this.txtX.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtX.Properties.Appearance.Options.UseFont = true;
      this.txtX.Size = new System.Drawing.Size(188, 22);
      this.txtX.TabIndex = 5;
      this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
      // 
      // txtY
      // 
      this.txtY.Location = new System.Drawing.Point(94, 174);
      this.txtY.Name = "txtY";
      this.txtY.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtY.Properties.Appearance.Options.UseFont = true;
      this.txtY.Size = new System.Drawing.Size(188, 22);
      this.txtY.TabIndex = 4;
      this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
      // 
      // txtNoktaNo
      // 
      this.txtNoktaNo.Location = new System.Drawing.Point(94, 141);
      this.txtNoktaNo.Name = "txtNoktaNo";
      this.txtNoktaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtNoktaNo.Properties.Appearance.Options.UseFont = true;
      this.txtNoktaNo.Size = new System.Drawing.Size(188, 22);
      this.txtNoktaNo.TabIndex = 3;
      this.txtNoktaNo.TextChanged += new System.EventHandler(this.txtNoktaNo_TextChanged);
      // 
      // txtParsel
      // 
      this.txtParsel.Location = new System.Drawing.Point(94, 108);
      this.txtParsel.Name = "txtParsel";
      this.txtParsel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtParsel.Properties.Appearance.Options.UseFont = true;
      this.txtParsel.Size = new System.Drawing.Size(188, 22);
      this.txtParsel.TabIndex = 2;
      this.txtParsel.TextChanged += new System.EventHandler(this.txtParsel_TextChanged);
      // 
      // txtAda
      // 
      this.txtAda.Location = new System.Drawing.Point(94, 75);
      this.txtAda.Name = "txtAda";
      this.txtAda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAda.Properties.Appearance.Options.UseFont = true;
      this.txtAda.Size = new System.Drawing.Size(188, 22);
      this.txtAda.TabIndex = 1;
      this.txtAda.TextChanged += new System.EventHandler(this.txtAda_TextChanged);
      // 
      // txtId
      // 
      this.txtId.Enabled = false;
      this.txtId.Location = new System.Drawing.Point(94, 42);
      this.txtId.Name = "txtId";
      this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtId.Properties.Appearance.Options.UseFont = true;
      this.txtId.Size = new System.Drawing.Size(188, 22);
      this.txtId.TabIndex = 0;
      this.txtId.Visible = false;
      // 
      // lblY
      // 
      this.lblY.AutoSize = true;
      this.lblY.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblY.Location = new System.Drawing.Point(64, 175);
      this.lblY.Name = "lblY";
      this.lblY.Size = new System.Drawing.Size(24, 16);
      this.lblY.TabIndex = 5;
      this.lblY.Text = "Y :";
      // 
      // lblX
      // 
      this.lblX.AutoSize = true;
      this.lblX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblX.Location = new System.Drawing.Point(63, 210);
      this.lblX.Name = "lblX";
      this.lblX.Size = new System.Drawing.Size(25, 16);
      this.lblX.TabIndex = 4;
      this.lblX.Text = "X :";
      // 
      // lblAda
      // 
      this.lblAda.AutoSize = true;
      this.lblAda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblAda.Location = new System.Drawing.Point(49, 78);
      this.lblAda.Name = "lblAda";
      this.lblAda.Size = new System.Drawing.Size(39, 16);
      this.lblAda.TabIndex = 3;
      this.lblAda.Text = "Ada :";
      // 
      // lblParsel
      // 
      this.lblParsel.AutoSize = true;
      this.lblParsel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblParsel.Location = new System.Drawing.Point(36, 111);
      this.lblParsel.Name = "lblParsel";
      this.lblParsel.Size = new System.Drawing.Size(52, 16);
      this.lblParsel.TabIndex = 2;
      this.lblParsel.Text = "Parsel :";
      // 
      // lblNoktaNo
      // 
      this.lblNoktaNo.AutoSize = true;
      this.lblNoktaNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblNoktaNo.Location = new System.Drawing.Point(20, 144);
      this.lblNoktaNo.Name = "lblNoktaNo";
      this.lblNoktaNo.Size = new System.Drawing.Size(68, 16);
      this.lblNoktaNo.TabIndex = 1;
      this.lblNoktaNo.Text = "Nokta No :";
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
      // Form2D
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1004, 591);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.gridControl1);
      this.Name = "Form2D";
      this.Text = "2D";
      this.Load += new System.EventHandler(this.Form2D_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtResimYolu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtX.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtY.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNoktaNo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblAda;
        private System.Windows.Forms.Label lblParsel;
        private System.Windows.Forms.Label lblNoktaNo;
        private DevExpress.XtraEditors.TextEdit txtX;
        private DevExpress.XtraEditors.TextEdit txtY;
        private DevExpress.XtraEditors.TextEdit txtNoktaNo;
        private DevExpress.XtraEditors.TextEdit txtParsel;
        private DevExpress.XtraEditors.TextEdit txtAda;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Label lblResim;
        public DevExpress.XtraEditors.TextEdit txtResimYolu;
    private DevExpress.XtraEditors.TextEdit txtId;
    private DevExpress.Data.ODataLinq.ODataInstantFeedbackSource oDataInstantFeedbackSource1;
  }
}