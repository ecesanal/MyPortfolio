using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
	public class _ContactComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{

			ViewBag.Phone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
			ViewBag.Email1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
			ViewBag.Address = context.Contacts.Select(x => x.Address).FirstOrDefault();
			return View();
		}
	}
}
