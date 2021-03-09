using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Paycompute.Entity;

namespace Paycompute.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
    }
         public DbSet<PaymentRecord> MyProperty { get; set; }
         public DbSet<Employee> Employees { get; set; }
         public DbSet<TaxYear> TaxYears { get; set; }
    }
}
