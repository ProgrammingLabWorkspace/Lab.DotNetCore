using Microsoft.AspNetCore.Mvc;
using MVC.FormLab.Models;

namespace MVC.FormLab.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao")]Aluno aluno)
        {
            //TODO: Configurar Entity Framework
            return View();
        }
    }
}
