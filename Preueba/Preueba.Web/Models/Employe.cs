using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Employe
    {
      [Key]
      public int EmployeId { get; set; }

        [Required]
        [Display(Name ="Nombre Del Empleado")]
        public string EmployeName { get; set; }

    }
}
