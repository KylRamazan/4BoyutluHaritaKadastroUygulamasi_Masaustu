namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImarDurumuBaslik")]
    public partial class ImarDurumuBaslik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImarDurumuBaslik()
        {
            ImarDurumu = new HashSet<ImarDurumu>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public bool? Silindi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImarDurumu> ImarDurumu { get; set; }
    }
}
