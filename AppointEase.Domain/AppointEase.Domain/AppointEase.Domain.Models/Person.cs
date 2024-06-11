using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointEase.Domain.AppointEase.Domain.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string? Emri { get; set; }
        public string? Mbiemri { get; set; }
        public int Mosha { get; set; }
    }
}
