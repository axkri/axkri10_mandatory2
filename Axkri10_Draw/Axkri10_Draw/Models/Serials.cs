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

    public class SerialGenerator
    {
        private int Serials = 101;
        public List<Serials> serialList { get; set; }

        public SerialGenerator()
        {
            serialList = new List<Serials>();
        }

        public void GenerateSerials()
        {
            Serials newSerials;
            for (int i = 1; i < Serials; i++)
            {
                newSerials = new Serials(i);
                serialList.Add(newSerials);
            }
        }

        public List<Serials> GetSerialList()
        {
            return serialList;
        }
    }
}