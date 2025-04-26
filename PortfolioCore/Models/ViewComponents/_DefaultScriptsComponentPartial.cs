using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{

    public class _DefaultScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
