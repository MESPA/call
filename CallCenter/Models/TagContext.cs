using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CallCenter.Models
{
    public class TagContext : DbContext
    {

        

        public TagContext()
           //Reference the name of your connection string ( WebAppCon )  
           : base("DefaultConnection") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<DescTag> DescTag { get; set; }


    }


}