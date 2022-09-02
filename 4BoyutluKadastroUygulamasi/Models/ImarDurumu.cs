namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImarDurumu")]
    public partial class ImarDurumu
    {
        public int Id { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public decimal? TapuAlani { get; set; }

        public int? ImarDurumuBaslik { get; set; }

        [StringLength(250)]
        public string ImarDurumuAciklama { get; set; }

        [StringLength(250)]
        public string Fotograf { get; set; }

        public bool? Silindi { get; set; }

        public virtual ImarDurumuBaslik ImarDurumuBaslik1 { get; set; }
    }
}
