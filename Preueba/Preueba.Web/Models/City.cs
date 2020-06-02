using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class City
    {
        [Required]
        [Display(Name = "Codigo")]
        public int CityId { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Ciudad")]
        public string CityName { get; set; }


        public int StateId { get; set; }

        public State StateNames { get; set; }

        public ICollection<Neighborhood> Neighborhoods { get; set; }

    }
}
