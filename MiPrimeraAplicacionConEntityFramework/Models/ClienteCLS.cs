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
        public string nombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string appaterno { get; set; }
        [Display(Name = "Segundo Apellido")]
    
        public string apmaterno { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int iidsexo { get; set; }
        [Display(Name = "Teléfono Fijo")]
        public string telefonofijo { get; set; }
        public string telefonocelular { get; set; }
        public int bhabilitado { get; set; }


    }
}