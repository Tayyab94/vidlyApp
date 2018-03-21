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
        [Column(TypeName ="nvarchar")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}