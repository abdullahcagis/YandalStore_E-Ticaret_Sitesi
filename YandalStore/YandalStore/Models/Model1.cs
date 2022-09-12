using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace YandalStore.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Brand> Brands { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductImage> ProductImages { get; set; }

        public virtual DbSet<ManagerType> ManagerTypes { get; set; }

        public virtual DbSet<Manager> Managers { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCart> UserCarts { get; set; }

        public virtual DbSet<Favorite> Favorites { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
