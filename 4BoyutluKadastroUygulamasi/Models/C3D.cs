namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("3D")]
    public partial class C3D
    {
        public int Id { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public decimal? ParselinOrtalamaKotu { get; set; }

        public int? TescilNesneTipi { get; set; }

        public decimal? TescilNesneKotu { get; set; }

        public decimal? KotFarki { get; set; }

        public bool? Silindi { get; set; }

        public virtual TescilNesneTipi TescilNesneTipi1 { get; set; }
    }
}
