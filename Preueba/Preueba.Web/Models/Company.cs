using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [Display(Name ="Nombre De Empresa")]
        public string CompanyName  { get; set; }

        [Required]
        [Display(Name ="Tipo De Empresa")]
        public string TypeCompany  { get; set; }
    }
}
