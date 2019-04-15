using Aprendendo.Models;
using Aprendendo.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aprendendo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string cidade, string especialidade)
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            CidadeDAO cidadeDAO = new CidadeDAO();
            EspecialidadeDAO especialidadeDAO = new EspecialidadeDAO();

            if (cidade != null || especialidade != null)
            {
                int valorCidade  = (cidade == null) ? 0 : int.Parse(cidade);
                int valorEsp = (especialidade == null) ? 0 : int.Parse(especialidade);

                ViewBag.Medicos = medicoDAO.busca(valorCidade, valorEsp);
            }
            else
            {
                ViewBag.Medicos = medicoDAO.Medicos();              
            }            
            
            IList<Cidade> cidades = cidadeDAO.Cidades();
            ViewBag.Cidades = cidades;

            IList<Especialidade> especialidades = especialidadeDAO.Especialidades();
            ViewBag.Especialidades = especialidades;

            return View();
        }
       
    }
}