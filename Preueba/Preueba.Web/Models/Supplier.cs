using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Supplier
    {
        public int IdSupplier { get; set; }

        [Required]
        [Display(Name ="Suplidor")]
        public string SupplierName { get; set; }

    }
}
