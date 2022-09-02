namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2D")]
    public partial class C2D
    {
        public int Id { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public int? NoktaNo { get; set; }

        public decimal? Y { get; set; }

        public decimal? X { get; set; }

        [StringLength(250)]
        public string ParselinGeometrikSekli { get; set; }

        public bool? Silindi { get; set; }
    }
}
