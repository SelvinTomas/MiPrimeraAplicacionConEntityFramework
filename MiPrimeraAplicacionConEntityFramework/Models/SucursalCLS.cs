using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class SucursalCLS
    {
        [Display(Name = "ID")]
        public int iidsucursal { get; set; }
        [Display(Name = "Nombre")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Dirección")]
        [StringLength(100, ErrorMessage = "Longitud máxima 200")]
        [Required]
        public string direccion { get; set; }
        [Display(Name = "Teléfono")]
        [StringLength(10, ErrorMessage = "Longitud máxima 10")]
        [Required]
        public string telefono { get; set; }
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [Required]
        public string email { get; set; }
        [Display(Name ="Fecha de apertura")]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime fechaApertura { get; set; }

        public int bhabilitado { get; set; }
    }
}