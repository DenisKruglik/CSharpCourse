namespace Forum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BannedUsers
    {
        public int Id { get; set; }

        public int Topic { get; set; }

        [Required]
        [StringLength(128)]
        public string User { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Topics Topics { get; set; }
    }
}
