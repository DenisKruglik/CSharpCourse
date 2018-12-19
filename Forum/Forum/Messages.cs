namespace Forum
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Messages
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Author { get; set; }

        public int Topic { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] CreatedAt { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Topics Topics { get; set; }
    }
}
