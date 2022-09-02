using _4BoyutluKadastroUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _4BoyutluKadastroUygulamasi.Forms
{
  public partial class Form2D : Form
  {
    private HaritaDB _ctx;
    public Form2D()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    private void Listele()
    {
      var veriler = (from d2 in _ctx.C2D
                     where d2.Silindi == false
                     select new
                     {
                       Id = d2.Id,
                       Ada = d2.Ada,
                       Parsel = d2.Parsel,
                       NoktaNo = d2.NoktaNo,
                       Y = d2.Y,
                       X = d2.X,
                       ParselinGeometrikSekli = d2.ParselinGeometrikSekli
                     }).OrderByDescending(x => x.Id).ToList();
      gridControl1.DataSource = veriler;
      gridView1.Columns[0].Caption = "Sıra No";

    }

    private void Form2D_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtId.Text == "" && txtAda.Text != "" && txtParsel.Text != "" && txtNoktaNo.Text != "" && txtY.Text != "" && txtX.Text != "")
        {
          C2D c2D = new C2D();
          c2D.Ada = Convert.ToInt32(txtAda.Text);
          c2D.Parsel = Convert.ToInt32(txtParsel.Text);
          c2D.NoktaNo = Convert.ToInt32(txtNoktaNo.Text);
          c2D.Y = Convert.ToDecimal(txtY.Text);
          c2D.X = Convert.ToDecimal(txtX.Text);
          c2D.ParselinGeometrikSekli = txtResimYolu.Text;
          c2D.Silindi = false;
          _ctx.C2D.Add(c2D);
          _ctx.SaveChanges();
          MessageBox.Show("2D Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
          var deger = _ctx.C2D.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }

          MessageBox.Show("2D Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      txtNoktaNo.Text = gridView1.GetFocusedRowCellValue("NoktaNo").ToString();
      txtY.Text = gridView1.GetFocusedRowCellValue("Y").ToString();
      txtX.Text = gridView1.GetFocusedRowCellValue("X").ToString();
      if (gridView1.GetFocusedRowCellValue("ParselinGeometrikSekli") != null)
      {
        txtResimYolu.Text = gridView1.GetFocusedRowCellValue("ParselinGeometrikSekli").ToString();
      }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      try
      {
        int id = Convert.ToInt32(txtId.Text);
        var deger = _ctx.C2D.Find(id);
        if (deger != null)
        {
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.NoktaNo = Convert.ToInt32(txtNoktaNo.Text);
          deger.Y = Convert.ToDecimal(txtY.Text);
          deger.X = Convert.ToDecimal(txtX.Text);
          deger.ParselinGeometrikSekli = txtResimYolu.Text;
          _ctx.SaveChanges();
          MessageBox.Show("2D Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      txtNoktaNo.Text = "";
      txtY.Text = "";
      txtX.Text = "";
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

    private void txtNoktaNo_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtNoktaNo.Text != "")
        {
          int sayi = Convert.ToInt32(txtNoktaNo.Text);
          errorProvider3.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider3.SetError(txtNoktaNo, "Lütfen Bu Alana Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtY_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtY.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtY.Text);
          errorProvider4.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider4.SetError(txtY, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
      }
    }

    private void txtX_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (txtX.Text != "")
        {
          decimal sayi = Convert.ToDecimal(txtX.Text);
          errorProvider5.Clear();
          btnKaydet.Enabled = true;
        }
      }
      catch (Exception)
      {
        errorProvider5.SetError(txtX, "Lütfen Bu Alana Ondalıklı(00.00) Sayı Giriniz!");
        btnKaydet.Enabled = false;
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

      if (gridView1.GetFocusedRowCellValue("ParselinGeometrikSekli") != null)
      {
        frmResim.resimYolu = gridView1.GetFocusedRowCellValue("ParselinGeometrikSekli").ToString();
        frmResim.txtResim.Text = gridView1.GetFocusedRowCellValue("ParselinGeometrikSekli").ToString();
      }
      frmResim.Show();
    }

    private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      if (e.Column.Caption == "Sıra No")
      {
        e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
      }
    }

    private void lblResim_Click(object sender, EventArgs e)
    {

    }

    private void txtResimYolu_EditValueChanged(object sender, EventArgs e)
    {

    }
  }
}
