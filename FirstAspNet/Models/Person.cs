using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string OtherInfo { get; set; }
        public int Age { get; set; }
        public short PostCode { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}