using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public Book PurchasedBook { get; set; }
        public Person PurchasePerson { get; set; }
        public DateTime Time { get; set; }
    }
}