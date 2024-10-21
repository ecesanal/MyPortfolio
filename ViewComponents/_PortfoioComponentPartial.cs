using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MyPortfolio.ViewComponents
{
    public class _PortfoioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
