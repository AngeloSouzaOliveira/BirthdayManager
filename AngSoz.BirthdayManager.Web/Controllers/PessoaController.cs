
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using AngSoz.BirthdayManager.Web.Date;
using AngSoz.BirthdayManager.Web.Models;
using System.Threading.Tasks;

namespace AngSoz.BirthdayManager.Web.Controllers
{
    public class PessoaController : Controller
    {

        private readonly Contexto _contexto;

        public PessoaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            List<Pessoa> pessoas;

            if (string.IsNullOrWhiteSpace(searchString))
            {
                pessoas = _contexto.Pessoas.ToList();
                return View(pessoas);
            }


            pessoas = _contexto.Pessoas.
                Where(pessoa => pessoa.Nome.Contains(searchString)).ToList();
            return View(pessoas);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Cadastro(Pessoa pessoa)
        {
            //Calculo da idade apartir da Data de nascimento
            var nascimento = pessoa.DataNascimento;
            var hoje = DateTime.Now;
            var idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
                idade--;

            pessoa.Idade = idade;


            //Validando dados em casos de dados incorretos 
            if (ModelState.IsValid)
            {
                _contexto.Add(pessoa);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(pessoa);
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            var pessoa = _contexto.Pessoas.Find(id);

            return View(pessoa);
        }


        [HttpPost]
        public IActionResult Editar(int id, Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //Calculo da idade apartir da Data de nascimento
                var nascimento = pessoa.DataNascimento;
                var hoje = DateTime.Now;
                var idade = hoje.Year - nascimento.Year;

                if (nascimento > hoje.AddYears(-idade))
                    idade--;

                pessoa.Idade = idade;

                _contexto.Pessoas.Update(pessoa);
                _contexto.SaveChanges();

                return Redirect("/Pessoa");
            }

            return View(pessoa);
        }


        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var pessoa = _contexto.Pessoas.Find(id);

            return View(pessoa);
        }


        [HttpPost]
        public IActionResult ExcluirPessoa(int id)
        {
            var pessoa = _contexto.Pessoas.Find(id);

            _contexto.Pessoas.Remove(pessoa);
            _contexto.SaveChanges();

            return Redirect("/Pessoa");
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var pessoa = _contexto.Pessoas
                .FirstOrDefault(p => p.Id == id);

            return View(pessoa);
        }


    }
}
