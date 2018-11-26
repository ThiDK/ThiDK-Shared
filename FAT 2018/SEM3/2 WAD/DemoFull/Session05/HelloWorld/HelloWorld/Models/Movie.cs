using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Movie
    {
 
        public int ID { get; set; }

        [Display(Name = "Tên Phim")]
        public string Title { get; set; }


        [Display(Name = "Ngày Phát Hành")]
        [DataType(DataType.Date)]
     
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Thể Loại")]
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Doanh Thu")]
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

    public class AhiiDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}