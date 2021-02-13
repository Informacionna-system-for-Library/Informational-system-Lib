using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Informational_system_Lib.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Addres { get; set; }
        public int PhoneNumber { get; set; }
        public int EGN { get; set; }
        public string NameOfBook { get; set; }
        public DateTime DateOfRecord { get; set; }
        public DateTime DateOfDeregistration { get; set; }
    }
}

