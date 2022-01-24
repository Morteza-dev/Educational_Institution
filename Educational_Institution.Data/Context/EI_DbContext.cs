using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Educational_Institution.Domain.Models.IdentityModel;
using Educational_Institution.Domain.Models.Entities;

namespace Educational_Institution.Data.Context
{
    public class EI_DbContext: IdentityDbContext<User,Role,int>
    {
        public EI_DbContext(DbContextOptions<EI_DbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Attr> Attrs { get; set; }
        public DbSet<AttrValue> AttrValues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Grad> Grads { get; set; }

    }
}
