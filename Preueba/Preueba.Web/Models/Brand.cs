using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        
        [Required]
        [Display(Name ="Marcas")]
        public string BrandName { get; set; }


       
        public Articles  Articles { get; set; }
    }

}
