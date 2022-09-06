using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionConEntityFramework.Models
{
    public class BusCLS
    {
        [Display(Name="Id")]
        public int iidBus { get; set; }
        [Display(Name = "Nombre de sucursal")]
        [Required]
        public int iidSucursal { get; set; }
        [Display(Name = "Tipo de bus")]
        [Required]
        public int iidTipoBus { get; set; }
        [Display(Name = "Placa")]
        [Required]
        [StringLength(100, ErrorMessage = "Longitud máxima de 100 caracteres")]
        public string placa { get; set; }
        [Display(Name = "Fecha de compra")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime fechaCompra { get; set; }
        [Display(Name = "Nombre de modelo")]
        [Required]
        public int iidModelo { get; set; }
        [Display(Name = "Número de filas")]
        [Required]
        public int numeroFilas { get; set; }
        [Display(Name = "Número de columnas")]
        [Required]
        public int numeroColumnas { get; set; }
        public int bhabilitado { get; set; }
        [Display(Name = "Descripción")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud máxima de 200 caracteres")]
        public string descripcion { get; set; }
        [Display(Name = "Observación")]
        [StringLength(200,ErrorMessage="Longitud máxima de 200 caracteres")]
        public string observacion { get; set; }

        [Display(Name = "Marca")]
        [Required]
        public int iidmarca { get; set; }




        //Propiedades adicionales
        [Display(Name = "Nombre de Sucursal")]
        public string nombreSucursal { get; set; }
        [Display(Name = "Tipo de Bus")]
        public string nombretipoBus { get; set; }
        [Display(Name = "Modelo")]
        public string nombreModelo { get; set; }

    }
}