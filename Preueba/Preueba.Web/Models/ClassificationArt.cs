using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Web.Models
{
    public class ClassificationArt
    {
        [Key]
        public int ArtcId { get; set; }

        [Required]
        [Display(Name ="Clasificacion Articulos")]
        public string NameArtc { get; set; }


        public ICollection<Brand> Brands { get; set; }
    }
}
