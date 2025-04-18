using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents

{
    public class _DefaultHeadComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
