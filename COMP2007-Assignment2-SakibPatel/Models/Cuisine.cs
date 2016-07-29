using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Assignment2_SakibPatel.Models
{
    public class Cuisine
    {
        /// <summary>
        /// this is an empty constructor
        /// </summary>
        public Cuisine()
        {

        }

        /// <summary>
        /// this constructor takes one param - Name
        /// </summary>
        /// <param name="Name"></param>
        
        public Cuisine(string Name)
        {
            this.Name = Name; 
        }

        public int CuisineID { get; set; }

        public string Name { get; set; }
    }
}