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
  public partial class Form4D : Form
  {
    private HaritaDB _ctx;
    public Form4D()
    {
      InitializeComponent();
      _ctx = new HaritaDB();
    }

    public void Listele()
    {
      gridControl1.DataSource = (from d4 in _ctx.C4D
                                 where d4.Silindi == false
                                 join parseldeMeydanaGelenDegisiklikler in _ctx.ParseldeMeydanaGelenDegisiklikler
                                 on d4.ParseldeMeydanaGelenDegisiklikler equals parseldeMeydanaGelenDegisiklikler.Id

                                 join degisiklikTipi in _ctx.DegisiklikTipi
                                 on d4.DegisiklikTipi equals degisiklikTipi.Id
                                 select new
                                 {
                                   Id = d4.Id,
                                   Ada = d4.Ada,
                                   Parsel = d4.Parsel,
                                   ParseldeMeydanaGelenDegisiklikler = parseldeMeydanaGelenDegisiklikler.Aciklama,
                                   DegisiklikTipi = degisiklikTipi.Aciklama,
                                   DegisikliginAciklamasi1 = d4.DegisikliginAciklamasi1,
                                   DegisikliginZamani1 = d4.DegisikliginZamani1,
                                   DegisikliginAciklamasi2 = d4.DegisikliginAciklamasi2,
                                   DegisikliginZamani2 = d4.DegisikliginZamani2,
                                   DegisikliginAciklamasi3 = d4.DegisikliginAciklamasi3,
                                   DegisikliginZamani3 = d4.DegisikliginZamani3,
                                   DegisikliginAciklamasi4 = d4.DegisikliginAciklamasi4,
                                   DegisikliginZamani4 = d4.DegisikliginZamani4
                                 }).OrderByDescending(x => x.Id).ToList();

      lookUpEdit1.Properties.DataSource = (from parseldeMeydanaGelenDegisiklikler in _ctx.ParseldeMeydanaGelenDegisiklikler
                                           where parseldeMeydanaGelenDegisiklikler.Silindi == false
                                           select new
                                           {
                                             Id = parseldeMeydanaGelenDegisiklikler.Id,
                                             Aciklama = parseldeMeydanaGelenDegisiklikler.Aciklama
                                           }).ToList();

      gridView1.Columns[0].Caption = "Sıra No";
    }

    public void Form4D_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      Temizle();

      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();

      int id = Convert.ToInt32(txtId.Text);

      var veriler = (from d4 in _ctx.C4D
                     where d4.Id == id && d4.Silindi == false
                     join parseldeMeydanaGelenDegisiklikler in _ctx.ParseldeMeydanaGelenDegisiklikler
                     on d4.ParseldeMeydanaGelenDegisiklikler equals parseldeMeydanaGelenDegisiklikler.Id

                     join degisiklikTipi in _ctx.DegisiklikTipi
                     on d4.DegisiklikTipi equals degisiklikTipi.Id
                     select new
                     {
                       Id = d4.Id,
                       Ada = d4.Ada,
                       Parsel = d4.Parsel,
                       ParseldeMeydanaGelenDegisiklikler = parseldeMeydanaGelenDegisiklikler.Aciklama,
                       DegisiklikTipi = degisiklikTipi.Aciklama,
                       DegisikliginAciklamasi1 = d4.DegisikliginAciklamasi1,
                       DegisikliginZamani1 = d4.DegisikliginZamani1,
                       DegisikliginAciklamasi2 = d4.DegisikliginAciklamasi2,
                       DegisikliginZamani2 = d4.DegisikliginZamani2,
                       DegisikliginAciklamasi3 = d4.DegisikliginAciklamasi3,
                       DegisikliginZamani3 = d4.DegisikliginZamani3,
                       DegisikliginAciklamasi4 = d4.DegisikliginAciklamasi4,
                       DegisikliginZamani4 = d4.DegisikliginZamani4,
                       DigerAciklama = d4.DigerAciklama,
                       DigerZaman = d4.DigerZaman
                     }).FirstOrDefault();

      txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("ParseldeMeydanaGelenDegisiklikler").ToString();
      lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("DegisiklikTipi").ToString();

      if (veriler.DegisikliginAciklamasi1 != null)
      {
        txtAciklama1.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi1").ToString();
        txtDegisiklikZamani1.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani1").ToString();
      }

      if (veriler.DegisikliginAciklamasi2 != null)
      {
        txtAciklama2.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi2").ToString();
        txtDegisiklikZamani2.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani2").ToString();
      }

      if (veriler.DegisikliginAciklamasi3 != null)
      {
        txtAciklama3.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi3").ToString();
        txtDegisiklikZamani3.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani3").ToString();
      }

      if (veriler.DegisikliginAciklamasi4 != null)
      {
        txtAciklama4.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi4").ToString();
        txtDegisiklikZamani4.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani4").ToString();
      }
    }

    private void Temizle()
    {
      txtId.Text = "";
      txtAda.Text = "";
      txtParsel.Text = "";
      txtAciklama1.Text = "";
      txtDegisiklikZamani1.Text = "";
      txtAciklama2.Text = "";
      txtDegisiklikZamani2.Text = "";
      txtAciklama3.Text = "";
      txtDegisiklikZamani3.Text = "";
      txtAciklama4.Text = "";
      txtDegisiklikZamani4.Text = "";
    }

    private void btnTemizle_Click(object sender, EventArgs e)
    {
      Temizle();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtId.Text == "" && txtAda.Text != "" && txtParsel.Text != "")
        {
          C4D c4D = new C4D();
          c4D.Ada = Convert.ToInt32(txtAda.Text);
          c4D.Parsel = Convert.ToInt32(txtParsel.Text);
          if (lookUpEdit1.EditValue != null && lookUpEdit2.EditValue != null)
          {
            c4D.ParseldeMeydanaGelenDegisiklikler = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
            c4D.DegisiklikTipi = Convert.ToInt32(lookUpEdit2.EditValue.ToString());

            if (txtAciklama1.Text != "")
            {
              c4D.DegisikliginAciklamasi1 = txtAciklama1.Text;
            }
            else
            {
              c4D.DegisikliginAciklamasi1 = null;
            }

            if (txtAciklama2.Text != "")
            {
              c4D.DegisikliginAciklamasi2 = txtAciklama2.Text;
            }
            else
            {
              c4D.DegisikliginAciklamasi2 = null;
            }

            if (txtAciklama3.Text != "")
            {
              c4D.DegisikliginAciklamasi3 = txtAciklama3.Text;
            }
            else
            {
              c4D.DegisikliginAciklamasi3 = null;
            }

            if (txtAciklama4.Text != "")
            {
              c4D.DegisikliginAciklamasi4 = txtAciklama4.Text;
            }
            else
            {
              c4D.DegisikliginAciklamasi4 = null;
            }

            if (txtDegisiklikZamani1.Text != "")
            {
              c4D.DegisikliginZamani1 = Convert.ToDateTime(txtDegisiklikZamani1.Text);
            }
            else
            {
              c4D.DegisikliginZamani1 = null;
            }

            if (txtDegisiklikZamani2.Text != "")
            {
              c4D.DegisikliginZamani2 = Convert.ToDateTime(txtDegisiklikZamani2.Text);
            }
            else
            {
              c4D.DegisikliginZamani2 = null;
            }

            if (txtDegisiklikZamani3.Text != "")
            {
              c4D.DegisikliginZamani3 = Convert.ToDateTime(txtDegisiklikZamani3.Text);
            }
            else
            {
              c4D.DegisikliginZamani3 = null;
            }

            if (txtDegisiklikZamani4.Text != "")
            {
              c4D.DegisikliginZamani4 = Convert.ToDateTime(txtDegisiklikZamani4.Text);
            }
            else
            {
              c4D.DegisikliginZamani4 = null;
            }

            c4D.Silindi = false;
            _ctx.C4D.Add(c4D);
            _ctx.SaveChanges();
            MessageBox.Show("4D Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
          }
          else
          {
            MessageBox.Show("Değişiklik Adını ve Tipini Seçtiğinizden Emin Olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
          var deger = _ctx.C4D.Find(id);
          if (deger != null)
          {
            deger.Silindi = true;
            _ctx.SaveChanges();
          }

          MessageBox.Show("4D Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        var deger = _ctx.C4D.Find(id);
        if (deger != null)
        {
          deger.Ada = Convert.ToInt32(txtAda.Text);
          deger.Parsel = Convert.ToInt32(txtParsel.Text);
          deger.ParseldeMeydanaGelenDegisiklikler = Convert.ToInt32(lookUpEdit1.EditValue.ToString());
          deger.DegisiklikTipi = Convert.ToInt32(lookUpEdit2.EditValue.ToString());

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

          _ctx.SaveChanges();
          MessageBox.Show("4D Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Listele();
          Temizle();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Güncelleme İşlemi Sırasında Hata Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
    {
      int secilen = Convert.ToInt32(lookUpEdit1.EditValue.ToString());

      lookUpEdit2.Properties.DataSource = (from degisiklikTipi in _ctx.DegisiklikTipi
                                           where degisiklikTipi.MeydanaGeldigiDegisiklik == secilen
                                           select new
                                           {
                                             Id = degisiklikTipi.Id,
                                             Aciklama = degisiklikTipi.Aciklama
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

    private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      if (e.Column.Caption == "Sıra No")
      {
        e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
      }
    }

    private void gridView1_DoubleClick(object sender, EventArgs e)
    {
      FormDetay4D formDetay4D = new FormDetay4D();

      formDetay4D.txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
      formDetay4D.txtAda.Text = gridView1.GetFocusedRowCellValue("Ada").ToString();
      formDetay4D.txtParsel.Text = gridView1.GetFocusedRowCellValue("Parsel").ToString();
      formDetay4D.txtDegisiklikler.Text = gridView1.GetFocusedRowCellValue("ParseldeMeydanaGelenDegisiklikler").ToString();
      formDetay4D.txtDegisiklikTipi.Text = gridView1.GetFocusedRowCellValue("DegisiklikTipi").ToString();

      if (gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi1") != null)
      {
        formDetay4D.txtAciklama1.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi1").ToString();
        formDetay4D.txtDegisiklikZamani1.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani1").ToString();
      }

      if (gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi2") != null)
      {
        formDetay4D.txtAciklama2.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi2").ToString();
        formDetay4D.txtDegisiklikZamani2.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani2").ToString();
      }

      if (gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi3") != null)
      {
        formDetay4D.txtAciklama3.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi3").ToString();
        formDetay4D.txtDegisiklikZamani3.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani3").ToString();
      }

      if (gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi4") != null)
      {
        formDetay4D.txtAciklama4.Text = gridView1.GetFocusedRowCellValue("DegisikliginAciklamasi4").ToString();
        formDetay4D.txtDegisiklikZamani4.Text = gridView1.GetFocusedRowCellValue("DegisikliginZamani4").ToString();
      }

      if (gridView1.GetFocusedRowCellValue("DigerAciklama") != null)
      {
        formDetay4D.txtAciklamaDiger.Text = gridView1.GetFocusedRowCellValue("DigerAciklama").ToString();
        formDetay4D.txtDegisiklikZamaniDiger.Text = gridView1.GetFocusedRowCellValue("DigerZaman").ToString();
      }

      formDetay4D.Show();
    }
  }
}
