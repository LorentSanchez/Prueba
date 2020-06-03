using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class City
    {   
        [Key]
        public int CityId { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Ciudad")]
        public string CityName { get; set; }


        public int StateId { get; set; }

        public State States { get; set; }

        public ICollection<Neighborhood> Neighborhoods { get; set; }

    }
}
