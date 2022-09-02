using _4BoyutluKadastroUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4BoyutluKadastroUygulamasi.Forms
{
  public partial class FormResim : Form
  {
    public delegate void Deneme(TextBox textBox);
    public event Deneme deneme;
    public string resimYolu;
    public FormResim()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormResim_Load(object sender, EventArgs e)
    {
      pictureBox1.ImageLocation = resimYolu;
    }

    private void btnResimEkle_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();

      string dosyaYolu = openFileDialog1.FileName;
      pictureBox1.ImageLocation = dosyaYolu;

      string[] parcalar = dosyaYolu.Split('\\');


      txtResim.Text = "C:\\Images\\"+parcalar[parcalar.Count()-1];
      this.deneme(txtResim);
      this.Close();
    }

    private void btnminimized_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
  }
}
