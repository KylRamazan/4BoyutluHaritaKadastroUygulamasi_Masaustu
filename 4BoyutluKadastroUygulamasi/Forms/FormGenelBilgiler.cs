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
  public partial class FormGenelBilgiler : Form
  {
    HaritaDB _ctx;
    public FormGenelBilgiler()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    private void Listele()
    {
      var veriler = (from genelBilgiler in _ctx.GenelBilgiler
                     where genelBilgiler.Silindi == false

                     join sehir in _ctx.iller
                     on genelBilgiler.Sehir equals sehir.id

                     join ilce in _ctx.ilceler
                     on genelBilgiler.Ilce equals ilce.id

                     select new
                     {
                       Id = genelBilgiler.Id,
                       Sehir = sehir.sehir,
                       Ilce = ilce.ilce,
                       Mahalle_Koy = genelBilgiler.Mahalle_Koy,
                       Mevkii = genelBilgiler.Mevkii,
                       Adres = genelBilgiler.Adres,
                       Ada = genelBilgiler.Ada,
                       Parsel = genelBilgiler.Parsel,
                       TapuAlani = genelBilgiler.TapuAlani,
                       Malik = genelBilgiler.Malik,
                       BabaAdi = genelBilgiler.BabaAdi,
                       Nitelik = genelBilgiler.Nitelik
                     }).OrderByDescending(x => x.Id).ToList();

      gridControl1.DataSource = veriler;
      gridView1.Columns[0].Caption = "Sıra No";

      lookUpEdit1.Properties.DataSource = (from sehir in _ctx.iller
                                           select new
                                           {
                                             id = sehir.id,
                                             sehir = sehir.sehir
                                           }).ToList();
    }

    private void FormGenelBilgiler_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtId.Text == "" && txtMahalle_Koy.Text != "" && txtMevkii.Text != "" && txtAdres.Text != "" && txtAda.Text != "" && txtParsel.Text != "" && txtTapuAlani.Text != "" && txtMalik.Text != "" && txtBabaAdi.Text != "" && txtNitelik.Text != "")
        {
          GenelBilgiler genelBilgiler = new GenelBilgiler();

          if (lookUpEdit1.EditValue != null && lookUpEdit2.EditValue != null)
          {
            genelBilgiler.Sehir = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
            genelBilgiler.Ilce = Convert.ToInt32(lookUpEdit2.EditValue.ToString());
            genelBilgiler.Mahalle_Koy = txtMahalle_Koy.Text;
            genelBilgiler.Mevkii = txtMevkii.Text;
            genelBilgiler.Adres = txtAdres.Text;
            genelBilgiler.Ada = Convert.ToInt32(txtAda.Text);
            genelBilgiler.Parsel = Convert.ToInt32(txtParsel.Text);
            genelBilgiler.TapuAlani = Convert.ToDecimal(txtTapuAlani.Text);
            genelBilgiler.Malik = txtMalik.Text;
            genelBilgiler.BabaAdi = txtBabaAdi.Text;
            genelBilgiler.Nitelik = txtNitelik.Text;
            genelBilgiler.Silindi = false;
            _ctx.GenelBilgiler.Add(genelBilgiler);
            _ctx.SaveChanges();
            MessageBox.Show("Genel Bilgiler Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
          }
          else
          {
            MessageBox.Show("Şehir ve İlçe Seçtiğinizden Emin Olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
          var deger = _ctx.GenelBilgiler.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }
          MessageBox.Show("Genel Bilgiler Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        var deger = _ctx.GenelBilgiler.Find(id);
        if (deger != null)
        {
          deger.Sehir = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
          deger.Ilce = Convert.ToInt32(lookUpEdit2.EditValue.ToString());
          deger.Mahalle_Koy = txtMahalle_Koy.Text;
          deger.Mevkii = txtMevkii.Text;
          deger.Adres = txtAdres.Text;
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.TapuAlani = Convert.ToDecimal(txtTapuAlani.Text);
          deger.Malik = txtMalik.Text;
          deger.BabaAdi = txtBabaAdi.Text;
          deger.Nitelik = txtNitelik.Text;
          _ctx.SaveChanges();
          MessageBox.Show("Genel Bilgiler Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      txtMahalle_Koy.Text = "";
      txtMevkii.Text = "";
      txtAdres.Text = "";
      txtAda.Text = "";
      txtParsel.Text = "";
      txtTapuAlani.Text = "";
      txtMalik.Text = "";
      txtBabaAdi.Text = "";
      txtNitelik.Text = "";
    }

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtMahalle_Koy.Text = gridView1.GetFocusedRowCellValue("Mahalle_Koy").ToString();
      txtMevkii.Text = gridView1.GetFocusedRowCellValue("Mevkii").ToString();
      txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      txtTapuAlani.Text = gridView1.GetFocusedRowCellValue("TapuAlani").ToString();
      txtMalik.Text = gridView1.GetFocusedRowCellValue("Malik").ToString();
      txtBabaAdi.Text = gridView1.GetFocusedRowCellValue("BabaAdi").ToString();
      txtNitelik.Text = gridView1.GetFocusedRowCellValue("Nitelik").ToString();
      lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Sehir").ToString();
      lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("Ilce").ToString();
    }

    private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
      int secilen = Convert.ToInt32(lookUpEdit1.EditValue.ToString());

      lookUpEdit2.Properties.DataSource = (from ilce in _ctx.ilceler
                                           where ilce.sehir == secilen
                                           select new
                                           {
                                             id = ilce.id,
                                             ilce = ilce.ilce
                                           }).ToList();
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

    private void txtTapuAlani_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtTapuAlani.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtTapuAlani.Text);
          errorProvider3.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider3.SetError(txtTapuAlani, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
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
