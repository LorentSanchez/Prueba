using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class Articles
    {
        [Key]
        public int ArticlesId { get; set; }

        [Required]
        [Display(Name ="Articulos")]
        public string ArticlesName { get; set; }

        [Required]
        [Display(Name ="Tipo De Articulo")]
        public string TypeArticles { get; set; }

        public ICollection<Brand> Brands { get; set; }

    }
}
