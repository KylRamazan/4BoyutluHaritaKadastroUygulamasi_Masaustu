namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TescilNesneTipi")]
    public partial class TescilNesneTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TescilNesneTipi()
        {
            C3D = new HashSet<C3D>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string NesneTipi { get; set; }

        public bool? Silindi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C3D> C3D { get; set; }
    }
}
