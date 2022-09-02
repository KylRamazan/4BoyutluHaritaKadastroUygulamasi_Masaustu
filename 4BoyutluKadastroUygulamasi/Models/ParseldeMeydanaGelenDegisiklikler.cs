namespace _4BoyutluKadastroUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParseldeMeydanaGelenDegisiklikler")]
    public partial class ParseldeMeydanaGelenDegisiklikler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParseldeMeydanaGelenDegisiklikler()
        {
            C4D = new HashSet<C4D>();
        }

        public int Id { get; set; }

        public string Aciklama { get; set; }

        public bool? Silindi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C4D> C4D { get; set; }
    }
}
