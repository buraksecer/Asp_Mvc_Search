using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Search.Models
{
    public class YemekSepeti
    {
        [Key]
        public int Yemek_Id { get; set; }

        public String Yemek_Adi { get; set; }

        public double Fiyat { get; set; }
        public YemekSepeti()
        {
            Yemek_Id = 0;
            Yemek_Adi = "Test";
            Fiyat = 0;
        }
    }

  

    public class databaseContext:DbContext
    {
        public DbSet<YemekSepeti> ContactYemekSepeti { get; set; }
    }

  

}    