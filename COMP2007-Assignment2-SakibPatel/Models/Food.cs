using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Assignment2_SakibPatel.Models
{
    public class Food
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Food()
        {

        }
        /// <summary>
        /// This constructor takes one param - Title
        /// </summary>
        /// <param name="Title"></param>
        
        public Food(string Title)
        {
            this.Title = Title;
        }

        public int FoodID { get; set; }

        public string Title { get; set; }

        public Cuisine Cuisine { get; set; }
    }
}