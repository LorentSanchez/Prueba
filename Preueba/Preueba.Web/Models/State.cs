using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class State
    {
        [Required]
        [Display(Name ="Codigo EStado")]
        public int StateId { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Nombre De Estado")]
        public string StateName { get; set; }

        public int CityId { get; set; }
        public City CityName { get; set; }
    }
}
