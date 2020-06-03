using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class TypeDocument
    {
        [Key]
        public int IdDocumet { get; set; }

        [Required]
        [Display(Name ="Tipo De Documento")]
        public string TypeDocum{ get; set; }

        [Required]
        [Display(Name ="Numero De Referencia")]
        public string Document { get; set; }

    }
}
