using Microsoft.AspNetCore.Mvc;

namespace RehabilitasyonProje.ViewComponents.Ogrenci
{
    public class OgrenciList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
