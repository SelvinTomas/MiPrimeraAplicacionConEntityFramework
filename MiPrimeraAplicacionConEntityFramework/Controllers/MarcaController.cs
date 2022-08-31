using MiPrimeraAplicacionConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionConEntityFramework.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarca = null;
            using (var db = new BDPasajeEntities())
            {
                listaMarca = (from marca in db.Marca
                              where marca.BHABILITADO == 1
                              select new MarcaCLS
                              {
                                  iidmarca = marca.IIDMARCA,
                                  nombre = marca.NOMBRE,
                                  descripcion = marca.DESCRIPCION

                              }).ToList();
            }
            return View(listaMarca);

            
        }
        public ActionResult Agregar()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Agregar(MarcaCLS oMarcaCLS)
        {
            if(!ModelState.IsValid)
            {
                return View(oMarcaCLS);
            }
            else
            {
                using (var db = new BDPasajeEntities())
                {
                    Marca oMarca = new Marca();
                    oMarca.NOMBRE = oMarcaCLS.nombre;
                    oMarca.DESCRIPCION = oMarcaCLS.descripcion;
                    oMarca.BHABILITADO = 1;
                    db.Marca.Add(oMarca);
                    db.SaveChanges();
                }
               
            }
            return RedirectToAction("Index");
        }
        
    }
}