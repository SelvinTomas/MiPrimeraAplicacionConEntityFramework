using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class ViajeCLS
    {
        [Display(Name = "Id")]
        public int iidViaje { get; set; }
        [Display(Name = "Lugar de Origen")]
        [Required]
        public int iidLugarOrigen { get; set; }
        [Display(Name = "Lugar de Destino")]
        [Required]
        public int iidLugarDestino { get; set; }
        [Display(Name = "Precio")]
        [Required]
        public double precio { get; set; }
        [Display(Name = "Fecha de viaje")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Required]
        public DateTime fechaViaje { get; set; }
        [Display(Name = "Bus")]
        [Required]
        public int iidBus { get; set; }
        [Display(Name = "Numero de asientos disponibles")]
        [Required]
        public int  numeroAsientosDisponible { get; set; }

        //Propiedades adicionales
        [Display(Name = "Lugar de origen")]
        public string nombreLugarOrigen { get; set; }
        [Display(Name = "Lugar de destino")]
        public string nombreLugarDestino { get; set; }
        [Display(Name = "Bus")]
        public string nombreBus { get; set; }



    }
}