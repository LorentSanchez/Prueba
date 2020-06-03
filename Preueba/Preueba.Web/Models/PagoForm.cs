using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class PagoForm
    {
        public int IdPago { get; set; }

        [Required]
        [Display(Name ="Forma De Pago")]
        public string pagoName { get; set; }

    }
}
