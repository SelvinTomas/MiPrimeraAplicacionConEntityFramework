using MiPrimeraAplicacionConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionConEntityFramework.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> listaCliente = null;
            using (var db = new BDPasajeEntities())
            {
                listaCliente = (from cliente in db.Cliente
                                where cliente.BHABILITADO == 1
                                select new ClienteCLS
                                {
                                    iidcliente = cliente.IIDCLIENTE,
                                    nombre = cliente.NOMBRE,
                                    appaterno = cliente.APPATERNO,
                                    apmaterno = cliente.APMATERNO,
                                    telefonocelular = cliente.TELEFONOCELULAR
                                }
                                ).ToList();
            }
            return View(listaCliente);
        }

        List<SelectListItem> listaSexo;
        private void llenarSexo()
        {
            using (var db = new BDPasajeEntities())
            {
                listaSexo = (from sexo in db.Sexo
                             where sexo.BHABILITADO == 1
                             select new SelectListItem
                             {
                                 Text=sexo.NOMBRE,
                                 Value=sexo.IIDSEXO.ToString()
                             }).ToList();
                listaSexo.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
            }
        }
        public ActionResult Agregar()
        {
            llenarSexo();
            ViewBag.lista = listaSexo;
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(ClienteCLS oClienteCLS)
        {
            if (!ModelState.IsValid)
            {
                llenarSexo();
                ViewBag.lista = listaSexo;
                return View(oClienteCLS);
            }
            else
            {
                using (var db = new BDPasajeEntities())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.NOMBRE = oClienteCLS.nombre;
                    oCliente.APPATERNO = oClienteCLS.appaterno;
                    oCliente.APMATERNO = oClienteCLS.apmaterno;
                    oCliente.EMAIL = oClienteCLS.email;
                    oCliente.DIRECCION = oClienteCLS.direccion;
                    oCliente.IIDSEXO = oClienteCLS.iidsexo;
                    oCliente.TELEFONOCELULAR = oClienteCLS.telefonocelular;
                    oCliente.TELEFONOFIJO = oClienteCLS.telefonofijo;
                    oCliente.BHABILITADO = 1;

                    db.Cliente.Add(oCliente);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

    }
}