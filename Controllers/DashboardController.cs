using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
