using System;
using Microsoft.AspNetCore.Mvc;
using Senai.Agenda.web.Mvc.Models;
namespace Senai.Agenda.web.Mvc.Controllers
{
    public class UsuarioController: Controller
    {
        [HttpGet]
        public ActionResult Cadastrar(){
        return View();
        }
    }
}