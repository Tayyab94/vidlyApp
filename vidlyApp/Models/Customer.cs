using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace vidlyApp.Models
{
    public class Customer
    {
      
        [Key]
        public int Id { get; set; }

       
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime? BithDate { get; set; }
        public bool IsSubscribeToNewsletter { get; set; }

        public virtual MemberShiptype MemberShiptype { get; set; }

    }
}