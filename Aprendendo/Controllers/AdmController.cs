using Aprendendo.Filters;
using Aprendendo.Models;
using Aprendendo.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aprendendo.Controllers
{
    [AutorizacaoFilter]
    public class AdmController : Controller
    {
        ICidadeDAO cidadeDAO = new CidadeDAO();
        IEspecialidadeDAO especialidadeDAO = new EspecialidadeDAO();
        IMedicoDAO medicoDAO = new MedicoDAO();
        IPaisDAO paisDAO = new PaisDAO();
        IEstadoDAO estadoDAO = new EstadoDAO();

        // GET: Adm
        public ActionResult Index()
        {      
            return View();
        }

        public ActionResult Medicos()
        {
            ViewBag.EspecialidadeId = new SelectList(especialidadeDAO.Especialidades(), "Id", "Nome");
            ViewBag.CidadeId = new SelectList(cidadeDAO.Cidades(), "Id", "Nome");

            return View();
        }
               
        public ActionResult Cidades()
        {
            ViewBag.EstadoId = new SelectList(estadoDAO.Estados(), "Id", "Nome");
            return View();
        }

        public ActionResult Especialidades()
        {
            ViewBag.Especialidade = new Especialidade();
            return View();
        }

        public ActionResult Estados()
        {
            ViewBag.PaisId = new SelectList(paisDAO.Paises(), "Id", "Nome");
            return View();
        }

        public ActionResult Paises()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Medicos(Medico medico)
        {
            if(ModelState.IsValid)
            {
                medicoDAO.adicionar(medico);

                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.EspecialidadeId = new SelectList(especialidadeDAO.Especialidades(), "Id", "Nome");
                ViewBag.CidadeId = new SelectList(cidadeDAO.Cidades(), "Id", "Nome");

                return View(medico);
            }
        }

        [HttpPost]
        public ActionResult Cidades(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                cidadeDAO.adicionar(cidade);

                return RedirectToAction("index");
            }
            else
            {              
                return View(cidade);
            }
        }

        [HttpPost]
        public ActionResult EspecialidadePost(Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                especialidadeDAO.adicionar(especialidade);

                return RedirectToAction("index");
            }
            else
            {
                ViewBag.Especialidade = especialidade;
                return View("Especialidades");
            }
        }

        [HttpPost]
        public ActionResult Paises(Pais pais)
        {
            if (ModelState.IsValid)
            {
                paisDAO.adicionar(pais);

                return RedirectToAction("index");
            }
            else
            {                
                return View(pais);
            }
        }

        [HttpPost]
        public ActionResult Estados(Estado estado)
        {
            if (ModelState.IsValid)
            {
                estadoDAO.adicionar(estado);

                return RedirectToAction("index");
            }
            else
            {               
                return View(estado);
            }
        }
    }
}