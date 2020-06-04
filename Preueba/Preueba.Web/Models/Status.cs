using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Status
    {
        public int IdStatus  { get; set; }

        [Required]
        [Display(Name ="Estatud ")]
        public string StatusName { get; set; }

        public int MyProperty { get; set; }
    }
}
