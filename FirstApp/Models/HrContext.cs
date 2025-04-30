// Ignore Spelling: App

using System;
using System.Data.SqlClient;
using Humanizer;
using Microsoft.EntityFrameworkCore;
namespace FirstApp.Models
{
    public class HrContext : DbContext
    {
        // Constrictor
        public HrContext()
        {

        }
        // properties
        public virtual DbSet<EmployeesModel> TbEmployees { get; set; }
        public virtual DbSet<DepartmentsModel> TbDepartment { get; set; }
        public virtual DbSet<EmployeeVacationModel> TbEmployeeVacation { get; set; }
        public virtual DbSet<InvoiceModel> TbInvoice { get; set; }
        public virtual DbSet<InvoiceDetails> TbInvoiceDetails { get; set; }
        public virtual DbSet<PersonModel> TbPerson { get; set; }
        public virtual DbSet<AllowancesModel> TbAllowancesModel { get; set; }
        public virtual DbSet<EmployeesAllowancesModel> TbEmployeesAllowances { get; set; }
        public virtual DbSet<CustomersModel> TbCustomers { get; set; }
        public virtual DbSet<CustomersInvoicesModel> TbCustomersInvoicesBr { get; set; }

        // Method
        //// configuration as siting
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FARIDFARID\\FARID_SERVER;database=HrApp;Trusted_Connection=True; TrustServerCertificate=Yes");
            }
        }

        //// configuration table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesModel>(entity =>
            {
                entity.Property(a => a.Description).HasMaxLength(4000).IsRequired();

                entity
                .HasOne(a => a.TbDepartment)
                .WithMany(a => a.Employees)
                .HasForeignKey(a => a.DepartmentId);


                entity
                .HasOne(a => a.TbPerson)
                .WithOne(a => a.TbEmployees)
                .HasForeignKey<EmployeesModel>(a => a.PersonId);
            });

            modelBuilder.Entity<DepartmentsModel>(entity =>
            {
                entity.HasKey(a => a.DepartmentId);
                entity.Property(a => a.DepartmentName).HasMaxLength(200);
            });

            modelBuilder.Entity<EmployeeVacationModel>(entity =>
            {
                entity.HasKey(a => a.EmployeeVacationId);

                entity
                .HasOne(a => a.TbEmployee)
                .WithMany(a => a.EmployeeVacation)
                .HasForeignKey(a => a.EmployeeId);
            });

            modelBuilder.Entity<InvoiceModel>(entity =>
            {
                entity.HasKey(a => a.InvoiceId);
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {

                entity.Property(a => a.Quantity).HasMaxLength(200);

                entity
                .HasOne(a => a.TbInvoiceDetails)
                .WithMany(a => a.InvoiceDetails)
                .HasForeignKey(a => a.InvoiceDetailId);
            });


            modelBuilder.Entity<EmployeesAllowancesModel>(entity =>
            {


                entity
                .HasOne(a => a.TbEmployees)
                .WithMany(a => a.EmployeesAllowances)
                .HasForeignKey(a => a.EmployeesId);

                entity
               .HasOne(a => a.TbAllowances)
               .WithMany(a => a.EmployeesAllowances)
               .HasForeignKey(a => a.AllowancesId);
            });



            modelBuilder.Entity<CustomersInvoicesModel>(entity =>
            {


                entity
                .HasOne(a => a.TbInvoice)
                .WithMany(a => a.CustomersInvoices)
                .HasForeignKey(a => a.InvoiceId);

                entity
               .HasOne(a => a.TbCustomer)
               .WithMany(a => a.CustomersInvoices)
               .HasForeignKey(a => a.CustomerId);
            });


        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(8,2)");
            configurationBuilder.Properties<DateTime>().HaveColumnType("DateTime");
        }
    }
}
