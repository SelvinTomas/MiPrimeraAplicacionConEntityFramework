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
        public string nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
        public int bhabilitado { get; set; }
    }
}