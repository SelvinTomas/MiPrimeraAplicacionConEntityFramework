using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class ClienteCLS
    {
        [Display(Name = "ID")]
        public int iidcliente { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100, ErrorMessage ="Longitud máxima 100")]
        public string nombre { get; set; }
        [Display(Name = "Primer Apellido")]
        [Required]
        [StringLength(150, ErrorMessage = "Longitud máxima 150")]
        public string appaterno { get; set; }
        [Display(Name = "Segundo Apellido")]
        [StringLength(150, ErrorMessage = "Longitud máxima 150")]
        [Required]
        public string apmaterno { get; set; }
        [Display(Name = "E-mail")]
        [StringLength(200, ErrorMessage = "Longitud máxima 200")]
        [EmailAddress(ErrorMessage ="Ingrese un Email válido")]
        [Required]
        public string email { get; set; }
        [Display(Name = "Dirección")]
        [StringLength(200, ErrorMessage = "Longitud máxima 200")]
        [Required]
        public string direccion { get; set; }
        [Display(Name = "Sexo")]
        [Required]
        public int iidsexo { get; set; }
        [Display(Name = "Teléfono Fijo")]
        [StringLength(10, ErrorMessage = "Longitud máxima 10")]
        [Required]
        public string telefonofijo { get; set; }
        [Display(Name = "Teléfono Celular")]
        [StringLength(10, ErrorMessage = "Longitud máxima 10")]
        [Required]
        public string telefonocelular { get; set; }

        public int bhabilitado { get; set; }


    }
}