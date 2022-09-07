using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class EmpleadoCLS
        
    {
        [Display(Name="Id")]

        public int iidEmpleado { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100 caracteres")]
        public string nombre { get; set; }

        [Display(Name = "Primer apellido")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(200, ErrorMessage = "Longitud máxima 200 caracteres")]
        public string apPaterno { get; set; }

        [Display(Name = "Segundo apellido")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(200, ErrorMessage = "Longitud máxima 200 caracteres")]
        public string apMaterno { get; set; }

        [Display(Name = "Fecha de contrato")]
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaContrato { get; set; }

        [Display(Name = "Tipo de usuario")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int iidtipoUsuario { get; set; }

        [Display(Name = "Sueldo")]
        [Range(0,100000,ErrorMessage ="Fuera de rango")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public decimal sueldo { get; set; }

        [Display(Name = "Tipo de contrato")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int iidtipoContrato { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int iidsexo { get; set; }

        public int bhabilitado { get; set; }

        //Propiedades adicionales

        [Display(Name ="Tipo de contrato")]
        public string nombreTipoContrato { get; set; }

        [Display(Name = "Tipo de usuario")]
                public string nombreTipoUsuario { get; set; }

    }
}