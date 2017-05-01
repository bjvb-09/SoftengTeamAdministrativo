using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SoftengTeamAdministrativo.Controllers
{
    public class HomeController : Controller
    {
        private HighGardenResortEntities db = new HighGardenResortEntities();

        // GET: Home
        public ActionResult Index()
        {
            if (Session["error"] != null)
            {
                ViewBag.Login = false;
                System.Web.HttpContext.Current.Session["error"] = null;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form)
        {
            string usuario = form["txtUsuario"];
            string contrasenna = form["txtContrasenna"];
            if (usuario == null   || contrasenna == null)
            {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

                var strSQL = from a in db.Administrador
                             where a.contrasennaAdministrador == contrasenna && a.usuarioAdministrador == usuario
                             select a;
            Administrador administrador = null;
            if (strSQL.FirstOrDefault() != null)
            {
                administrador = strSQL.First();
            }
            System.Web.HttpContext.Current.Session["administrador"] = administrador;

            if (administrador == null)
            {
                System.Web.HttpContext.Current.Session["error"] = true;
                return RedirectToAction("Index");
            }
            return RedirectToAction("../Administradors/Index");
        }
    }
}