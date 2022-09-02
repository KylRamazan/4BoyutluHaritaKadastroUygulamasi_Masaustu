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
  public partial class FormImarDurumu : Form
  {
    private HaritaDB _ctx;
    public FormImarDurumu()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    private void Listele()
    {
      var veriler = (from imarDurumu in _ctx.ImarDurumu
                     where imarDurumu.Silindi == false
                     join imarDurumuBaslik in _ctx.ImarDurumuBaslik
                     on imarDurumu.ImarDurumuBaslik equals imarDurumuBaslik.Id
                     select new
                     {
                       Id = imarDurumu.Id,
                       Ada = imarDurumu.Ada,
                       Parsel = imarDurumu.Parsel,
                       TapuAlani = imarDurumu.TapuAlani,
                       ImarDurumuBaslik = imarDurumuBaslik.Aciklama,
                       ImarDurumuAciklama = imarDurumu.ImarDurumuAciklama,
                       Fotograf = imarDurumu.Fotograf
                     }).OrderByDescending(x => x.Id).ToList();

      gridControl1.DataSource = veriler;
      gridView1.Columns[0].Caption = "Sıra No";

      lookUpEdit1.Properties.DataSource = (from imarDurumuBaslik in _ctx.ImarDurumuBaslik
                                           where imarDurumuBaslik.Silindi == false
                                           select new
                                           {
                                             Id = imarDurumuBaslik.Id,
                                             Aciklama = imarDurumuBaslik.Aciklama
                                           }).ToList();
    }

    private void FormImarDurumu_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      txtTapuAlani.Text = gridView1.GetFocusedRowCellValue("TapuAlani").ToString();
      txtAciklama.Text = gridView1.GetFocusedRowCellValue("ImarDurumuAciklama").ToString();
      lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("ImarDurumuBaslik").ToString();
      txtResimYolu.Text = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtId.Text == "" && txtAda.Text != "" && txtParsel.Text != "" && txtTapuAlani.Text != "" && txtAciklama.Text != "")
        {
          ImarDurumu imarDurumu = new ImarDurumu();
          imarDurumu.Ada = Convert.ToInt32(txtAda.Text);
          imarDurumu.Parsel = Convert.ToInt32(txtParsel.Text);
          imarDurumu.TapuAlani = Convert.ToDecimal(txtTapuAlani.Text);
          imarDurumu.Fotograf = txtResimYolu.Text;

          if (lookUpEdit1.EditValue != null)
          {
            imarDurumu.ImarDurumuBaslik = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
            imarDurumu.ImarDurumuAciklama = txtAciklama.Text;
            imarDurumu.Silindi = false;
            _ctx.ImarDurumu.Add(imarDurumu);
            _ctx.SaveChanges();
            MessageBox.Show("İmar Durumu Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
          }
          else
          {
            MessageBox.Show("İmar Durumunu Seçtiğinizden Emin Olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
          var deger = _ctx.ImarDurumu.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }

          MessageBox.Show("İmar Durumu Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        var deger = _ctx.ImarDurumu.Find(id);
        if (deger != null)
        {
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.TapuAlani = Convert.ToDecimal(txtTapuAlani.Text);
          deger.ImarDurumuBaslik = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
          deger.ImarDurumuAciklama = txtAciklama.Text;
          deger.Fotograf = txtResimYolu.Text;
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
      txtTapuAlani.Text = "";
      txtAciklama.Text = "";
      txtResimYolu.Text = "";
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

    private void btnResimEkle_Click(object sender, EventArgs e)
    {
      FormResim frmResim = new FormResim();
      frmResim.deneme += new FormResim.Deneme(resimYoluYaz);
      frmResim.Show();
    }

    void resimYoluYaz(TextBox textBox)
    {
      txtResimYolu.Text = textBox.Text;
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      FormResim frmResim = new FormResim();
      frmResim.deneme += new FormResim.Deneme(resimYoluYaz);

      if (gridView1.GetFocusedRowCellValue("Fotograf") != null)
      {
        frmResim.resimYolu = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
        frmResim.txtResim.Text = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
      }
      frmResim.Show();
    }
  }
}
