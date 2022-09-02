namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("4D")]
    public partial class C4D
    {
        public int Id { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public int? ParseldeMeydanaGelenDegisiklikler { get; set; }

        public int? DegisiklikTipi { get; set; }

        public string DegisikliginAciklamasi1 { get; set; }

        public DateTime? DegisikliginZamani1 { get; set; }

        public string DegisikliginAciklamasi2 { get; set; }

        public DateTime? DegisikliginZamani2 { get; set; }

        public string DegisikliginAciklamasi3 { get; set; }

        public DateTime? DegisikliginZamani3 { get; set; }

        public string DegisikliginAciklamasi4 { get; set; }

        public DateTime? DegisikliginZamani4 { get; set; }

        public string DigerAciklama { get; set; }

        public DateTime? DigerZaman { get; set; }

        public bool? Silindi { get; set; }

        public virtual DegisiklikTipi DegisiklikTipi1 { get; set; }

        public virtual ParseldeMeydanaGelenDegisiklikler ParseldeMeydanaGelenDegisiklikler1 { get; set; }
    }
}
