using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RealEstate.Models
{
    public partial class RealEstateContext : DbContext
    {
        public virtual DbSet<TblDummy> TblDummy { get; set; }
		public virtual DbSet<Property> Property { get; set; }
		public virtual DbSet<Agent> Agent { get; set; }

		public RealEstateContext(DbContextOptions<RealEstateContext> options)
    : base(options)
{ }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var connection = @"Server=(localdb)\mssqllocaldb;Database=RealEstate;Trusted_Connection=True;ConnectRetryCount=0";
				optionsBuilder.UseSqlServer(connection);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDummy>(entity =>
            {
                entity.ToTable("tblDummy");

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
