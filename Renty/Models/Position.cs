using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Renty.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int RealtyId { get; set; }
        public int RealtorId { get; set; }
    }
}