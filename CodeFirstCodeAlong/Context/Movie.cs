using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstCodeAlong.Context
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MinLength(0)]
        public int Runtime { get; set; }
    }

    //Context 
    //Needs 3 things:
    //1) Subclass DbContext 
    //2) Create a constructor passing in options 
    //3) A DbSet<model> for each table you want to make

    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions options) : base(options)
        {
        }
    }
}
