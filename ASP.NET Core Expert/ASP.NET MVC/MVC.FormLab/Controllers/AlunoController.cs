using Microsoft.AspNetCore.Mvc;
using MVC.FormLab.Models;

namespace MVC.FormLab.Controllers
{
    public class AlunoController : Controller
    {
        private AppDbContext DbContext;

        public AlunoController(AppDbContext context)
        {
            DbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao")]Aluno aluno)
        {
            //TODO: Configurar Entity Framework

            DbContext.Alunos.Add(aluno);
            await DbContext.SaveChangesAsync();

            return View();
        }
    }
}
