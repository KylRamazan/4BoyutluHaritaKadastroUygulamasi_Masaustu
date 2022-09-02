
namespace _4BoyutluKadastroUygulamasi.Forms
{
    partial class FormResim
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResim));
      this.pnlTitleBar = new System.Windows.Forms.Panel();
      this.btnminimized = new System.Windows.Forms.PictureBox();
      this.btnClose = new System.Windows.Forms.PictureBox();
      this.lblResim = new System.Windows.Forms.Label();
      this.iconResim = new FontAwesome.Sharp.IconPictureBox();
      this.pnlDesktop = new System.Windows.Forms.Panel();
      this.txtResim = new System.Windows.Forms.TextBox();
      this.btnResimEkle = new System.Windows.Forms.Button();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.pnlTitleBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.btnminimized)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconResim)).BeginInit();
      this.pnlDesktop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTitleBar
      // 
      this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
      this.pnlTitleBar.Controls.Add(this.btnminimized);
      this.pnlTitleBar.Controls.Add(this.btnClose);
      this.pnlTitleBar.Controls.Add(this.lblResim);
      this.pnlTitleBar.Controls.Add(this.iconResim);
      this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
      this.pnlTitleBar.Name = "pnlTitleBar";
      this.pnlTitleBar.Size = new System.Drawing.Size(500, 75);
      this.pnlTitleBar.TabIndex = 2;
      // 
      // btnminimized
      // 
      this.btnminimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnminimized.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnminimized.Image = ((System.Drawing.Image)(resources.GetObject("btnminimized.Image")));
      this.btnminimized.Location = new System.Drawing.Point(410, 26);
      this.btnminimized.Name = "btnminimized";
      this.btnminimized.Size = new System.Drawing.Size(26, 26);
      this.btnminimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.btnminimized.TabIndex = 4;
      this.btnminimized.TabStop = false;
      this.btnminimized.Click += new System.EventHandler(this.btnminimized_Click);
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.Location = new System.Drawing.Point(451, 26);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(26, 26);
      this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.btnClose.TabIndex = 2;
      this.btnClose.TabStop = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblResim
      // 
      this.lblResim.AutoSize = true;
      this.lblResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblResim.ForeColor = System.Drawing.Color.Gainsboro;
      this.lblResim.Location = new System.Drawing.Point(55, 32);
      this.lblResim.Name = "lblResim";
      this.lblResim.Size = new System.Drawing.Size(96, 16);
      this.lblResim.TabIndex = 1;
      this.lblResim.Text = "Resim Ekleme";
      // 
      // iconResim
      // 
      this.iconResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
      this.iconResim.ForeColor = System.Drawing.Color.MediumPurple;
      this.iconResim.IconChar = FontAwesome.Sharp.IconChar.Images;
      this.iconResim.IconColor = System.Drawing.Color.MediumPurple;
      this.iconResim.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconResim.InitialImage = null;
      this.iconResim.Location = new System.Drawing.Point(17, 26);
      this.iconResim.Name = "iconResim";
      this.iconResim.Size = new System.Drawing.Size(32, 32);
      this.iconResim.TabIndex = 0;
      this.iconResim.TabStop = false;
      // 
      // pnlDesktop
      // 
      this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
      this.pnlDesktop.Controls.Add(this.txtResim);
      this.pnlDesktop.Controls.Add(this.btnResimEkle);
      this.pnlDesktop.Controls.Add(this.labelControl1);
      this.pnlDesktop.Controls.Add(this.pictureBox1);
      this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlDesktop.Location = new System.Drawing.Point(0, 75);
      this.pnlDesktop.Name = "pnlDesktop";
      this.pnlDesktop.Size = new System.Drawing.Size(500, 425);
      this.pnlDesktop.TabIndex = 4;
      // 
      // txtResim
      // 
      this.txtResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtResim.Location = new System.Drawing.Point(156, 297);
      this.txtResim.Name = "txtResim";
      this.txtResim.Size = new System.Drawing.Size(280, 22);
      this.txtResim.TabIndex = 8;
      // 
      // btnResimEkle
      // 
      this.btnResimEkle.BackColor = System.Drawing.Color.MediumPurple;
      this.btnResimEkle.FlatAppearance.BorderSize = 0;
      this.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnResimEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnResimEkle.ForeColor = System.Drawing.Color.White;
      this.btnResimEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.Image")));
      this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnResimEkle.Location = new System.Drawing.Point(230, 354);
      this.btnResimEkle.Name = "btnResimEkle";
      this.btnResimEkle.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
      this.btnResimEkle.Size = new System.Drawing.Size(120, 30);
      this.btnResimEkle.TabIndex = 7;
      this.btnResimEkle.Text = "Resim Ekle";
      this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnResimEkle.UseVisualStyleBackColor = false;
      this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.Location = new System.Drawing.Point(56, 300);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(94, 16);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Resim Konumu :";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(122, 34);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(265, 223);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // FormResim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 500);
      this.Controls.Add(this.pnlDesktop);
      this.Controls.Add(this.pnlTitleBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormResim";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormResim";
      this.Load += new System.EventHandler(this.FormResim_Load);
      this.pnlTitleBar.ResumeLayout(false);
      this.pnlTitleBar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.btnminimized)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconResim)).EndInit();
      this.pnlDesktop.ResumeLayout(false);
      this.pnlDesktop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox btnminimized;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblResim;
        private FontAwesome.Sharp.IconPictureBox iconResim;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtResim;
    }
}