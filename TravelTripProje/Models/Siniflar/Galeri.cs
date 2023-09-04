using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Galeri
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }

        public string GaleriBaslik { get; set; }    
    }
}