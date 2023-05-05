using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string Addres { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
    }
}