namespace Forum
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BannedUsers> BannedUsers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.BannedUsers)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.CreatedAt)
                .IsFixedLength();

            modelBuilder.Entity<Topics>()
                .HasMany(e => e.BannedUsers)
                .WithRequired(e => e.Topics)
                .HasForeignKey(e => e.Topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Topics>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Topics)
                .HasForeignKey(e => e.Topic)
                .WillCascadeOnDelete(false);
        }
    }
}
