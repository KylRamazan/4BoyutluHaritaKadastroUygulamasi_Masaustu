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
  public partial class Form5D : Form
  {
    private HaritaDB _ctx;
    public Form5D()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    public void Listele()
    {
      var veriler = (from d5 in _ctx.C5D
                     where d5.Silindi == false

                     select new
                     {
                       Id = d5.Id,
                       Ada = d5.Ada,
                       Parsel = d5.Parsel,
                       EmlakBeyanDegeriYili = d5.EmlakBeyanDegeriYili,
                       PiyasaDegeriYili = d5.PiyasaDegeriYili,
                       EmlakBeyanDegeriFiyati = d5.EmlakBeyanDegeriFiyati,
                       PiyasaDegeriFiyati = d5.PiyasaDegeriFiyati,
                       Mahalle = d5.Mahalle,
                       CepheAlinanCadde_Sokak = d5.CepheAlinanCadde_Sokak
                     }).OrderByDescending(x => x.Id).ToList();

      gridControl1.DataSource = veriler;
      gridView1.Columns[0].Caption = "Sıra No";
    }

    private void Form5D_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      txtBeyanDegeriYili.Text = gridView1.GetFocusedRowCellValue("EmlakBeyanDegeriYili").ToString();
      txtPiyasaDegeriYili.Text = gridView1.GetFocusedRowCellValue("PiyasaDegeriYili").ToString();
      txtBeyanDegeriFiyati.Text = gridView1.GetFocusedRowCellValue("EmlakBeyanDegeriFiyati").ToString();
      txtPiyasaDegeriFiyati.Text = gridView1.GetFocusedRowCellValue("PiyasaDegeriFiyati").ToString();
      txtMahalle.Text = gridView1.GetFocusedRowCellValue("Mahalle").ToString();
      txtCepheAlinanCadSok.Text = gridView1.GetFocusedRowCellValue("CepheAlinanCadde_Sokak").ToString();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {

      try
      {
        if (txtId.Text == "" && txtAda.Text != "" && txtParsel.Text != "" && txtBeyanDegeriYili.Text != "" && txtPiyasaDegeriYili.Text != "" && txtBeyanDegeriFiyati.Text != "" && txtPiyasaDegeriFiyati.Text != "" && txtMahalle.Text != "" && txtCepheAlinanCadSok.Text != "")
        {
          C5D c5D = new C5D();
          c5D.Ada = Convert.ToInt32(txtAda.Text);
          c5D.Parsel = Convert.ToInt32(txtParsel.Text);
          c5D.EmlakBeyanDegeriYili = Convert.ToInt32(txtBeyanDegeriYili.Text);
          c5D.PiyasaDegeriYili = Convert.ToInt32(txtPiyasaDegeriYili.Text);
          c5D.EmlakBeyanDegeriFiyati = Convert.ToDecimal(txtBeyanDegeriFiyati.Text);
          c5D.PiyasaDegeriFiyati = Convert.ToDecimal(txtPiyasaDegeriFiyati.Text);
          c5D.Mahalle = txtMahalle.Text;
          c5D.CepheAlinanCadde_Sokak = txtCepheAlinanCadSok.Text;
          c5D.Silindi = false;
          _ctx.C5D.Add(c5D);
          _ctx.SaveChanges();
          MessageBox.Show("5D Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Listele();
          Temizle();
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
          var deger = _ctx.C5D.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }

          MessageBox.Show("5D Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        var deger = _ctx.C5D.Find(id);
        if (deger != null)
        {
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.EmlakBeyanDegeriYili = Convert.ToInt32(txtBeyanDegeriYili.Text);
          deger.PiyasaDegeriYili = Convert.ToInt32(txtPiyasaDegeriYili.Text);
          deger.EmlakBeyanDegeriFiyati = Convert.ToDecimal(txtBeyanDegeriFiyati.Text);
          deger.PiyasaDegeriFiyati = Convert.ToDecimal(txtPiyasaDegeriFiyati.Text);
          deger.Mahalle = txtMahalle.Text;
          deger.CepheAlinanCadde_Sokak = txtCepheAlinanCadSok.Text;
          _ctx.SaveChanges();
          MessageBox.Show("5D Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      txtBeyanDegeriYili.Text = "";
      txtPiyasaDegeriYili.Text = "";
      txtBeyanDegeriFiyati.Text = "";
      txtPiyasaDegeriFiyati.Text = "";
      txtMahalle.Text = "";
      txtCepheAlinanCadSok.Text = "";
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

    private void txtBeyanDegeriYili_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtBeyanDegeriYili.Text != "")
        {
          int sayi = Convert.ToInt32(txtBeyanDegeriYili.Text);
          errorProvider3.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider3.SetError(txtBeyanDegeriYili, "Lütfen Bu Alana Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtPiyasaDegeriYili_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtPiyasaDegeriYili.Text != "")
        {
          int sayi = Convert.ToInt32(txtPiyasaDegeriYili.Text);
          errorProvider4.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider4.SetError(txtPiyasaDegeriYili, "Lütfen Bu Alana Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtBeyanDegeriFiyati_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtBeyanDegeriFiyati.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtBeyanDegeriFiyati.Text);
          errorProvider5.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider5.SetError(txtBeyanDegeriFiyati, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtPiyasaDegeriFiyati_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtPiyasaDegeriFiyati.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtPiyasaDegeriFiyati.Text);
          errorProvider6.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider6.SetError(txtPiyasaDegeriFiyati, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
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
