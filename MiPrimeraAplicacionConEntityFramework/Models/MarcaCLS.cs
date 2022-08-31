using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class MarcaCLS
    {
        [Display(Name = "Id")]
        public int iidmarca { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100,ErrorMessage = "La longitud máxima es 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion")]
        [Required]
        [StringLength(200, ErrorMessage = "La longitud máxima es 200")]
        public string descripcion { get; set; }
        public int bhabilitado { get; set; }
    }
}