using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class TEST_DbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            modelBuilder.Entity<Department>().Property(E => E.CreationDate).HasColumnType("Date")
                            .HasDefaultValueSql("getdate()");


            modelBuilder.Entity<Department>().HasMany(d => d.employees)
                                .WithOne(e => e.department)
                                        .HasForeignKey(e=>e.DepartmentId).IsRequired(false);

            modelBuilder.Entity<Department>()
                        .HasOne(d=>d.Manager)
                                .WithOne(d=>d.Manage)
                                .HasForeignKey<Department>(d=>d.ManagerId).IsRequired(false);


            modelBuilder.Entity<Department>().Property(d => d.Id).UseIdentityColumn(10, 10);
        }

        public TEST_DbContext() : base()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; DataBase = TEST; Trusted_Connection= True; Encrypt= True; TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }

}
