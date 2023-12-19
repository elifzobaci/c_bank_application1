using bankapplicationc.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapplicationc_.classes
{
    public  class BankDbContext : DbContext
    {
        // DbSet<Customer> Customers özelliği, Customer sınıfını temsil eden veritabanı tablosunu belirtir.
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerImage> CustomerImages { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // UseSqlServer metodu, SQL Server veritabanı ile bağlantıyı yapılandırır.
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BankApplication3;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(a => a.CustomerImageID)
                .WithOne(a => a.Customer) //birebir ilişki kurulmus
                .HasForeignKey<CustomerImage>(c => c.CustomerImageID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            //customerimage tablosunda image bos olabılmesını saglıyor
            // Transfer -> Account (SourceAccount) ilişkisi için
             modelBuilder.Entity<Transfer>()
                .HasOne(t => t.SourceAccount)
                .WithMany()
                .HasForeignKey(c => c.SourceAccountID)
                  .OnDelete(DeleteBehavior.Restrict);
                  



            // veya gerekirse diğer eylemleri belirtin

            // Transfer -> Account (DestinationAccount) ilişkisi için
            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.DestinationAccount)
                .WithMany()
                .HasForeignKey(c=>c.DestinationAccountID)
              .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Transfer>()
           .HasOne(t => t.TransactionLog)
             .WithMany()
            .HasForeignKey(c => c.TransactionLogId)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<TransactionLog>()
           .HasOne(t => t.Account)
           .WithMany()
           .HasForeignKey(c => c.AccountID)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransactionLog>()
          .HasOne(t => t.Transfer)
          .WithMany()
          .HasForeignKey(c => c.TransferID)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransactionLog>()
            .HasOne(t => t.Customer)
            .WithMany()
            .HasForeignKey(c => c.CustomerID)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
