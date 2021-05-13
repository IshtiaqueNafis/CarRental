using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class CarRentals
    {
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public DateTime DateRented { get; set; }
        [Required]
        public DateTime DateReturned { get; set; }
        [Required]
        public decimal Cost { get; set; }

        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }
       


    }
}
