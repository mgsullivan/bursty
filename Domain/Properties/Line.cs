namespace Domain.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bursty.Lines")]
    public partial class Line
    {
        public int Id { get; set; }

        public long Number { get; set; }

        public int CheckId { get; set; }

        public virtual Check Check { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
