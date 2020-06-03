using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class PuestTra
    {
        public int IdPuest { get; set; }

        [Required]
        [Display(Name ="Puesto De Empleado ")]
        public string puestoName { get; set; }



        public int Employe { get; set; }
        public Employe Employees { get; set; }
    }
}
