using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Tutorial_C35.Models {
    /* This class must inherit another class. After the classname you put in a : to inherit another class. 
     * Choose the first solution. DbContext is part of any of the Database package we downloaded from. 
     * Whatever classes you put in here will be the ones you'll interact with in your application. */
    public class AppDbContext : DbContext {
                            // DbSet<>The class we want to interact with.
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Item> Items { get; set; }  

        /*Default Constructor. We only need this because it's a console app. */
        public AppDbContext() { }
        //Constructor. Configures how this is going to work. Have to use this for other classes
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options) {}
          
        /* protected is accessible to the classes that it's defined and also with classes that it's inherited in. */
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            
            if(!builder.IsConfigured) { //connection string
                builder.UseSqlServer("server=localhost\\sqlexpress;database=SalesDb1;trusted_connection=true;"); 
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            // makes Code unique
            builder.Entity<Item>(
                e => e.HasIndex(x => x.Code)
                .IsUnique(true));
        }
    }

}
