using System;
using System.Collections.Generic;
using System.Linq;
using vidlyApp.Models;
using System.Web;

namespace vidlyApp.DataViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShiptype> MemberShiptypes { get; set; }
      public Customer Customer { get; set;
        }
    }
}