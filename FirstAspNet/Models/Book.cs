using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public short Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime StartSellingDate { get; set; }
        public short PageCount { get; set; }
        public string Language { get; set; }

    }
}