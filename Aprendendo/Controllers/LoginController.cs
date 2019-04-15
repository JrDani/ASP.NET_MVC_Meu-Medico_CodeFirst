using Aprendendo.Models;
using Aprendendo.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Aprendendo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autentica(String username, String password)
        {
          
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = usuarioDAO.busca(username, password);

            if(usuario != null)
            {
                Session["usuario"] = usuario.Id;
                return RedirectToAction("index", "Adm");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos");
                
                return View("index");
            }
            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("index", "home");
        }
    }
}