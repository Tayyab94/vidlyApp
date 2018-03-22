using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidlyApp.Models
{
    public class MemberShiptype
    {
        public byte Id { get; set; }

        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMont { get; set; }

        public byte DiscountInRate { get; set; }
    }

}