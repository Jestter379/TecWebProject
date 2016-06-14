﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TecWeb.Controllers
{
    public class CursoController : Controller
    {

        public ActionResult Detalles(long id)
        {
            if (!Util.Sesion.Authenticated())
            {
                return RedirectToAction("Index", "Home");
            }
            var serv = new ControlAsistencia.ControlAsistenciaClient();
            var Curso = serv.Curso(id);
            return View(Curso);
        }
    }
}