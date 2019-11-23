using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Search.Models
{
    public class FoodBasket
    {
        [Key]
        public int Food_Id { get; set; }

        public String Food_Name { get; set; }

        public double Price { get; set; }
        
        public FoodBasket()
        {
            Food_Id = 0;
            Food_Name = "Test";
            Price = 0;
        }
    }
    public class databaseContext:DbContext
    {
        public DbSet<FoodBasket> ContactFoodBasket { get; set; }
    }
}    
