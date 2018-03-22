using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vidlyApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd,yyyy}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd,yyyy}",ApplyFormatInEditMode =true)]
        public DateTime DateAdded { get; set; }

        public int Stock { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}