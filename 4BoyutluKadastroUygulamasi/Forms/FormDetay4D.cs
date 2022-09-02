using _4BoyutluKadastroUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4BoyutluKadastroUygulamasi.Forms
{
  public partial class FormDetay4D : Form
  {
    private HaritaDB _ctx;
    public FormDetay4D()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnminimized_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      try
      {
        int id = Convert.ToInt32(txtId.Text);
        var deger = _ctx.C4D.Find(id);
        if (deger != null)
        {
          if (txtAciklama1.Text != "")
          {
            deger.DegisikliginAciklamasi1 = txtAciklama1.Text;
          }
          else
          {
            deger.DegisikliginAciklamasi1 = null;
          }

          if (txtAciklama2.Text != "")
          {
            deger.DegisikliginAciklamasi2 = txtAciklama2.Text;
          }
          else
          {
            deger.DegisikliginAciklamasi2 = null;
          }

          if (txtAciklama3.Text != "")
          {
            deger.DegisikliginAciklamasi3 = txtAciklama3.Text;
          }
          else
          {
            deger.DegisikliginAciklamasi3 = null;
          }

          if (txtAciklama4.Text != "")
          {
            deger.DegisikliginAciklamasi4 = txtAciklama4.Text;
          }
          else
          {
            deger.DegisikliginAciklamasi4 = null;
          }

          if (txtAciklamaDiger.Text != "")
          {
            deger.DigerAciklama = txtAciklamaDiger.Text;
          }
          else
          {
            deger.DigerAciklama = null;
          }

          if (txtDegisiklikZamani1.Text != "")
          {
            deger.DegisikliginZamani1 = Convert.ToDateTime(txtDegisiklikZamani1.Text);
          }
          else
          {
            deger.DegisikliginZamani1 = null;
          }

          if (txtDegisiklikZamani2.Text != "")
          {
            deger.DegisikliginZamani2 = Convert.ToDateTime(txtDegisiklikZamani2.Text);
          }
          else
          {
            deger.DegisikliginZamani2 = null;
          }

          if (txtDegisiklikZamani3.Text != "")
          {
            deger.DegisikliginZamani3 = Convert.ToDateTime(txtDegisiklikZamani3.Text);
          }
          else
          {
            deger.DegisikliginZamani3 = null;
          }

          if (txtDegisiklikZamani4.Text != "")
          {
            deger.DegisikliginZamani4 = Convert.ToDateTime(txtDegisiklikZamani4.Text);
          }
          else
          {
            deger.DegisikliginZamani4 = null;
          }

          if (txtDegisiklikZamaniDiger.Text != "")
          {
            deger.DigerZaman = Convert.ToDateTime(txtDegisiklikZamaniDiger.Text);
          }
          else
          {
            deger.DigerZaman = null;
          }

          _ctx.SaveChanges();
          MessageBox.Show("4D Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Güncelleme İşlemi Sırasında Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
