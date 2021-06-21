using AngSoz.BirthdayManager.Web.Date;
using AngSoz.BirthdayManager.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;




namespace AngSoz.BirthdayManager.Web.Controllers
{
    public class PresenteController : Controller
    {
        private readonly Contexto _contexto;

        public PresenteController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var listar= _contexto.Presentes.Include(p => p.Pessoas);
            return View(listar.ToList());
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewData["PessoaId"] = new SelectList(_contexto.Pessoas, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Presente presente)
        {

            if (ModelState.IsValid)
            {
                _contexto.Add(presente);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["PessoaId"] = new SelectList(_contexto.Pessoas, "Id", "Nome", presente.PessoaId);
            return View(presente);
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            var presente = _contexto.Presentes.Find(id);

            ViewData["PessoaId"] = new SelectList(_contexto.Pessoas, "Id", "Nome", presente.PessoaId);
            return View(presente);

        }


        [HttpPost]
        public IActionResult Editar(int id, Presente presente)
        {
            if (id != presente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _contexto.Update(presente);
                _contexto.SaveChanges();

                return Redirect("Index");
            }

            ViewData["PessoaId"] = new SelectList(_contexto.Pessoas, "Id", "Nome", presente.PessoaId);
            return View(presente);
        }


        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var presente = _contexto.Presentes
                .Include(p => p.Pessoas).FirstOrDefault(x => x.Id == id);
            return View(presente);
        }


        [HttpPost]
        public IActionResult ExcluirPresente(int id)
        {
            var presente = _contexto.Presentes
                .Include(p => p.Pessoas).FirstOrDefault(x => x.Id == id);

            _contexto.Presentes.Remove(presente);
            _contexto.SaveChanges();

            return Redirect("Index");
        }


        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var presente = _contexto.Presentes
                .Include(p => p.Pessoas).FirstOrDefault(x => x.Id == id);
            return View(presente);
        }





    }
}
