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


        public int ArtcId { get; set; }

        public ClassificationArt ClassificationArts { get; set; }

        public int BrandId { get; set; }

        public Brand Brands { get; set; }

    }
}
