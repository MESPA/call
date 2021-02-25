using CallCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallCenter.Controllers
{
    public class HomeController : Controller
    {
        private TagContext db = new TagContext();
        public ActionResult Index()
        {
          
            
                ViewBag.Tag = new List<SelectListItem>(db.DescTag.Select(l => new SelectListItem
                { Value = l.DescripcionTag.ToString(), Text = l.DescripcionTag }));

               

       

            return View();
        }

        [HttpPost]
        public ActionResult Index(string opcion,string otros, string comentario)
        {
            if (opcion != "Seleccione un tema" )
            {
                var tg = new Tag();

                tg.tema = opcion;
                tg.descripcion = comentario;
                tg.Otros = otros;
                db.Tag.Add(tg);
                db.SaveChanges();

                ViewBag.Mensaje = "Su registro se completo con exito";

            }
            else {
                ViewBag.ErrorMensaje = SweetAlertHelper.ShowMessage("Error", "Debe seleccionar un tema", SweetAlertMessageType.error); ;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}