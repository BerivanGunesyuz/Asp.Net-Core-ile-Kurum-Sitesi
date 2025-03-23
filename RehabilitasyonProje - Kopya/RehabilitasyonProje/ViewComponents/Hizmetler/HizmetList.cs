using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace RehabilitasyonProje.ViewComponents.Hizmetler
{
    public class HizmetList: ViewComponent
    {
        HizmetlerManager hizmetManager = new HizmetlerManager(new EfHizmetlerDal());

        public IViewComponentResult Invoke()
        {
            var values = hizmetManager.GetList();
            return View(values);
        }
    }
}
