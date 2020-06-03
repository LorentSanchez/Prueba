using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class ClasfSupplier
    {
        [Key]
        public int IdSupplierCals { get; set; }

        [Required]
        [Display(Name ="Clasificacion De Suplidor")]
        public string SupplierClasName { get; set; }

         
    }
}
