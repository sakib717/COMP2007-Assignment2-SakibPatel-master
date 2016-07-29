using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COMP2007_Assignment2_SakibPatel.Models
{
    public class PatelBistroContext : DbContext 
    {
        public virtual DbSet<Cuisine> Cuisines { get; set; }

        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<Description> Descriptions { get; set; }

    }
}