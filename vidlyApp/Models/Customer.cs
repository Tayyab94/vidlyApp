using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidlyApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BithDate { get; set; }
        public bool IsSubscribeToNewsletter { get; set; }

        [Display(Name = "MemberShip Type")]
        public MemberShiptype MemberShiptype { get; set; }

        public int MemberShiptypeId { get; set; }


    }
}