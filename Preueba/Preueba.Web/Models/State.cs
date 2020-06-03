using Prueba.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class State
    {   
        [Key]
       public int StateId { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name ="Nombre De Estado")]
        public string StateName { get; set; }

       
        public ICollection<City> Citys { get; set; }

        public int CountryId { get; set; }
        public Country Countrys { get; set; }
    }

}
