using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Axkri10_Draw.Models
{
    [Serializable]
    public class Serials
    {
        public int SerialNumber { get; set; }
        public int IsValid { get; set; }

        public Serials() { }

        public Serials(int serialNumber)
        {
            SerialNumber = serialNumber;
        }
    }
}