using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId  { get; set; }

        [Required]
        [Display(Name ="Tipo De Moneda")]
        public string TypeCurrency   { get; set; }
    }
}
