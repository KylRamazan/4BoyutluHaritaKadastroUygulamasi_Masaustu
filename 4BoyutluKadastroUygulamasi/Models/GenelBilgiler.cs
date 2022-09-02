namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenelBilgiler")]
    public partial class GenelBilgiler
    {
        public int Id { get; set; }

        public int? Sehir { get; set; }

        public int? Ilce { get; set; }

        [StringLength(250)]
        public string Mahalle_Koy { get; set; }

        [StringLength(250)]
        public string Mevkii { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public decimal? TapuAlani { get; set; }

        [StringLength(250)]
        public string Malik { get; set; }

        [StringLength(250)]
        public string BabaAdi { get; set; }

        [StringLength(250)]
        public string Nitelik { get; set; }

        public bool? Silindi { get; set; }

        public virtual ilceler ilceler { get; set; }

        public virtual iller iller { get; set; }
    }
}
