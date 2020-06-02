using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Models
{
    public class Owner
    {
        [Key]
        [Required]//para que los campos sea obliatorios llenarlos 
        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]//en tama$o maximo que tendran los campos 
        [Display(Name = "Identidad")]
        public int DocumentoId { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Nombre del cliente ")]
        public string NombreC { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Apellido del Cliente")]
        public string ApellidoC { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Telefono")]
        public string TelefonC { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Direccion")]
        public string DireccionC { get; set; }

        public string NombreCompleto => $"{NombreC} {ApellidoC}";
    }
}
