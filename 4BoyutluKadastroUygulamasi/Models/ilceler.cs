namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ilceler")]
    public partial class ilceler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ilceler()
        {
            GenelBilgiler = new HashSet<GenelBilgiler>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string ilce { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sehir { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GenelBilgiler> GenelBilgiler { get; set; }

        public virtual iller iller { get; set; }
    }
}
