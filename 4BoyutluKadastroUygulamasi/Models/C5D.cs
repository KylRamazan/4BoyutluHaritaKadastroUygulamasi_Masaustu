namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("5D")]
    public partial class C5D
    {
        public int Id { get; set; }

        public int? Ada { get; set; }

        public int? Parsel { get; set; }

        public int? EmlakBeyanDegeriYili { get; set; }

        public int? PiyasaDegeriYili { get; set; }

        public decimal? EmlakBeyanDegeriFiyati { get; set; }

        public decimal? PiyasaDegeriFiyati { get; set; }

        [StringLength(250)]
        public string Mahalle { get; set; }

        [StringLength(250)]
        public string CepheAlinanCadde_Sokak { get; set; }

        public bool? Silindi { get; set; }
    }
}
