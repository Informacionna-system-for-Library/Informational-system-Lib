using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Informational_system_Lib.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Zaglavie { get; set; }
        public string Avtor { get; set; }
        public string Janr { get; set; }
        public int Kolichestvo { get; set; }
    }
}
