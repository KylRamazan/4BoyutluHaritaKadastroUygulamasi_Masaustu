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
  public partial class Form3D : Form
  {
    private HaritaDB _ctx;
    public Form3D()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    private void Listele()
    {
      var veriler = (from d3 in _ctx.C3D
                     where d3.Silindi == false
                     join tescilNesneTipi in _ctx.TescilNesneTipi
                     on d3.TescilNesneTipi equals tescilNesneTipi.Id
                     select new
                     {
                       Id = d3.Id,
                       Ada = d3.Ada,
                       Parsel = d3.Parsel,
                       ParselinOrtalamaKotu = d3.ParselinOrtalamaKotu,
                       TescilNesneTipi = tescilNesneTipi.NesneTipi,
                       TescilNesneKotu = d3.TescilNesneKotu,
                       KotFarki = d3.KotFarki
                     }).OrderByDescending(x => x.Id).ToList();

      gridControl1.DataSource = veriler;
      gridView1.Columns[0].Caption = "Sıra No";
    }

    private void TescilNesneTipiListele()
    {
      lookUpEdit1.Properties.DataSource = (from nesneTipi in _ctx.TescilNesneTipi
                                           where nesneTipi.Silindi == false
                                           select new
                                           {
                                             Id = nesneTipi.Id,
                                             NesneTipi = nesneTipi.NesneTipi
                                           }).ToList();
    }

    private void Form3D_Load(object sender, EventArgs e)
    {
      Listele();
      TescilNesneTipiListele();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtId.Text == "" && txtAda.Text != "" && txtParsel.Text != "" && txtParselinOrtKotu.Text != "" && txtTescilNesneKotu.Text != "" && txtKotFarki.Text != "")
        {
          C3D c3D = new C3D();
          c3D.Ada = Convert.ToInt32(txtAda.Text);
          c3D.Parsel = Convert.ToInt32(txtParsel.Text);
          c3D.ParselinOrtalamaKotu = Convert.ToDecimal(txtParselinOrtKotu.Text);

          if (lookUpEdit1.EditValue != null)
          {
            c3D.TescilNesneTipi = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
            c3D.TescilNesneKotu = Convert.ToDecimal(txtTescilNesneKotu.Text);
            c3D.KotFarki = Convert.ToDecimal(txtKotFarki.Text);
            c3D.Silindi = false;
            _ctx.C3D.Add(c3D);
            _ctx.SaveChanges();
            MessageBox.Show("3D Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
          }
          else
          {
            MessageBox.Show("Tescil Nesne Tipini Seçtiğinizden Emin Olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }

        }
        else if (txtId.Text != "")
        {
          MessageBox.Show("Böyle Bir Kayıt Bulunmaktadır!\nLütfen Önce Temizle Butonunu Kullanarak Alanları Temizleyiniz. Daha Sonra Kayıt Ekleme İşlemini Gerçekleştiriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
          MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Ekleme İşlemi Sırasında Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      DialogResult cevap = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

      try
      {
        if (cevap == DialogResult.Yes)
        {
          int id = Convert.ToInt32(txtId.Text);
          var deger = _ctx.C3D.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }

          MessageBox.Show("3D Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Listele();
          Temizle();
        }
        else
        {
          MessageBox.Show("Silme İşlemi İptal Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Silme İşlemi Sırasında Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      try
      {
        int id = Convert.ToInt32(txtId.Text);
        var deger = _ctx.C3D.Find(id);
        if (deger != null)
        {
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.ParselinOrtalamaKotu = Convert.ToDecimal(txtParselinOrtKotu.Text);
          deger.TescilNesneTipi = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
          deger.TescilNesneKotu = Convert.ToDecimal(txtTescilNesneKotu.Text);
          deger.KotFarki = Convert.ToDecimal(txtKotFarki.Text);
          _ctx.SaveChanges();
          MessageBox.Show("3D Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Listele();
          Temizle();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Güncelleme İşlemi Sırasında Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }

    private void btnTemizle_Click(object sender, EventArgs e)
    {
      Temizle();
    }

    private void Temizle()
    {
      txtId.Text = "";
      txtAda.Text = "";
      txtParsel.Text = "";
      txtParselinOrtKotu.Text = "";
      txtTescilNesneKotu.Text = "";
      txtKotFarki.Text = "";
      TescilNesneTipiListele();
    }

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      txtParselinOrtKotu.Text = gridView1.GetFocusedRowCellValue("ParselinOrtalamaKotu").ToString();
      txtTescilNesneKotu.Text = gridView1.GetFocusedRowCellValue("TescilNesneKotu").ToString();
      txtKotFarki.Text = gridView1.GetFocusedRowCellValue("KotFarki").ToString();
      lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("TescilNesneTipi").ToString();
    }

    private void txtAda_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtAda.Text != "")
        {
          int sayi = Convert.ToInt32(txtAda.Text);
          errorProvider1.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider1.SetError(txtAda, "Lütfen Bu Alana Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtParsel_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtParsel.Text != "")
        {
          int sayi = Convert.ToInt32(txtParsel.Text);
          errorProvider2.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider2.SetError(txtParsel, "Lütfen Bu Alana Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtParselinOrtKotu_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtParselinOrtKotu.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtParselinOrtKotu.Text);
          errorProvider3.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider3.SetError(txtParselinOrtKotu, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtTescilNesneKotu_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtTescilNesneKotu.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtTescilNesneKotu.Text);
          errorProvider5.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider5.SetError(txtTescilNesneKotu, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtKotFarki_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtKotFarki.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtKotFarki.Text);
          errorProvider6.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider6.SetError(txtKotFarki, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      if (e.Column.Caption == "Sıra No")
      {
        e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
      }
    }
  }
}
