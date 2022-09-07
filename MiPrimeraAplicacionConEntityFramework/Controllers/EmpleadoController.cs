using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionConEntityFramework.Models;
namespace MiPrimeraAplicacionConEntityFramework.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            List<EmpleadoCLS> listaEmpleado = null;
            using (var db = new BDPasajeEntities())
            {
                listaEmpleado = (from empleado in db.Empleado
                                 join tipoUsuario in db.TipoUsuario
                                 on empleado.IIDTIPOUSUARIO equals tipoUsuario.IIDTIPOUSUARIO
                                 join tipoContrato in db.TipoContrato
                                 on empleado.IIDTIPOCONTRATO equals tipoContrato.IIDTIPOCONTRATO
                                 select new EmpleadoCLS
                                 {
                                     iidEmpleado = empleado.IIDEMPLEADO,
                                     nombre = empleado.NOMBRE,
                                     apPaterno = empleado.APPATERNO,
                                     apMaterno = empleado.APMATERNO,
                                     nombreTipoUsuario = tipoUsuario.NOMBRE,
                                     nombreTipoContrato = tipoContrato.NOMBRE

                                 }).ToList();
            }
            return View(listaEmpleado);
        }
        public void listarComboSexo()
        {
            //Agregar listado
            List<SelectListItem> lista;
                using (var db = new BDPasajeEntities()){
                lista = (from sexo in db.Sexo
                         where sexo.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text = sexo.NOMBRE,
                             Value = sexo.IIDSEXO.ToString()
                         }).ToList();
                lista.Insert(0,new SelectListItem{ Text ="--Selecione--",Value=""});
                ViewBag.listaSexo = lista;
                }
        }

        public void listaTipoContrato()
        {
            //Agregar listado de tipo contrato
            List<SelectListItem> lista;
            using (var db = new BDPasajeEntities())
            {
                lista = (from tipoContrato in db.TipoContrato
                         where tipoContrato.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text = tipoContrato.NOMBRE,
                             Value = tipoContrato.IIDTIPOCONTRATO.ToString()
                         }).ToList();
                lista.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                ViewBag.listaTipoContrato = lista;
            }
        }
        public void listaTipoUsuario()
        {
            //Agregar listado de tipos de usuario
            List<SelectListItem> lista;
            using (var db = new BDPasajeEntities())
            {
                lista = (from tipoUsuario in db.TipoUsuario
                         where tipoUsuario.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text = tipoUsuario.NOMBRE,
                             Value = tipoUsuario.IIDTIPOUSUARIO.ToString()
                         }).ToList();
                lista.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                ViewBag.listaTipoUsuario = lista;
            }
        }
        public void listarCombos()
        {
            listaTipoUsuario();
            listaTipoContrato();
            listarComboSexo();
        }
        public ActionResult Agregar()
        {
            listarCombos();
            return View();        
        }
        [HttpPost]
        public ActionResult Agregar(EmpleadoCLS oEmpleadoCLS)
        {
            if (!ModelState.IsValid)
            {
                listarCombos();
                return View(oEmpleadoCLS);
            }
            using (var db = new BDPasajeEntities())
            {
                Empleado oEmpleado = new Empleado();
                oEmpleado.NOMBRE = oEmpleadoCLS.nombre;
                oEmpleado.APPATERNO = oEmpleadoCLS.apPaterno;
                oEmpleado.APMATERNO = oEmpleadoCLS.apMaterno;
                oEmpleado.FECHACONTRATO = oEmpleadoCLS.fechaContrato;
                oEmpleado.SUELDO = oEmpleadoCLS.sueldo;
                oEmpleado.IIDTIPOUSUARIO = oEmpleadoCLS.iidtipoUsuario;
                oEmpleado.IIDTIPOCONTRATO = oEmpleadoCLS.iidtipoContrato;
                oEmpleado.IIDSEXO = oEmpleadoCLS.iidsexo;
                oEmpleado.BHABILITADO = 1;
                db.Empleado.Add(oEmpleado);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}