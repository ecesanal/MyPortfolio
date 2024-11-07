using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x=>x.isRead==false).Count();
			ViewBag.v4 = context.Messages.Where(x=>x.isRead==true).Count();

			ViewBag.e1 = context.Experiences.Count();
			ViewBag.e2 = context.Experiences.Where(x=>x.Date == "27/06/2022").Count();
			ViewBag.e3 = context.Experiences.Where(x=>x.Date == "03/07/2023").Count();
			ViewBag.e4 = context.Experiences.Where(x=>x.Date == "07/08/2023").Count();

			return View();
		}
	}
}
