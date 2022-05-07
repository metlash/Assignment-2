using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusTravels.Models
{
    public class Bus
    {
        [Key]
        [Required]
        public int BusId { get; set; }


        [Required]

        public string BoardingPoint { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime TravelDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

    }
}