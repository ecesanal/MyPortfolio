using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPatial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
