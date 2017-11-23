namespace Domain.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bursty.Checks")]
    public partial class Check
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Check()
        {
            Lines = new HashSet<Line>();
        }

        public int Id { get; set; }

        [Required]
        public string Pattern { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? LastCheck { get; set; }

        public bool Hit { get; set; }

        public bool Repeat { get; set; }

        public int LogID { get; set; }

        public virtual Log Log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Line> Lines { get; set; }
    }
}
