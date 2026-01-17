using Microsoft.AspNetCore.Mvc;

namespace Lab.MVC.AppSemTemplate.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    public class GestaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
