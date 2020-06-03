using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }

        [Required]
        [Display(Name ="Nombre De Venderor")]
        public string VendedorName { get; set; }


    }
}
