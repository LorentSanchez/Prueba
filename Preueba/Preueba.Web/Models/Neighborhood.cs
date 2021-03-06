﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class Neighborhood
    {   
        [Key]
       public int NeighborhoodId { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Municipio")]
        public string NeighborhoodName { get; set; }

        public int CityId { get; set; }

        public City Citys { get; set; }
    }
}
