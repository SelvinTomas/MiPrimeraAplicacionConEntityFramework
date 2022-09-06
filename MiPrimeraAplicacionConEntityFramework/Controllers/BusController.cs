using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionConEntityFramework.Models;

namespace MiPrimeraAplicacionConEntityFramework.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            List<BusCLS> listaBus = null;
            using (var db = new BDPasajeEntities())
            {
                listaBus = (from bus in db.Bus
                            join sucursal in db.Sucursal
                            on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                            join tipoBus in db.TipoBus
                            on bus.IIDTIPOBUS equals tipoBus.IIDTIPOBUS
                            join tipoModelo in db.Modelo
                            on bus.IIDMODELO equals tipoModelo.IIDMODELO
                            where bus.BHABILITADO == 1
                            select new BusCLS
                            {
                                iidBus = bus.IIDBUS,
                                nombreModelo = tipoModelo.NOMBRE,
                                placa = bus.PLACA,
                                nombreSucursal = sucursal.NOMBRE,
                                nombretipoBus = tipoBus.NOMBRE

                            }).ToList();
            }
            return View(listaBus);
        }
    }
}