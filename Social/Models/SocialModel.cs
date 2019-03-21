namespace Social.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SocialModel : DbContext
    {
        public SocialModel()
            : base("name=SocialModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Social.User> Users { get; set; }

        public System.Data.Entity.DbSet<Social.Universe> Universes { get; set; }

        public System.Data.Entity.DbSet<Social.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<Social.Description> Descriptions { get; set; }
    }
}
