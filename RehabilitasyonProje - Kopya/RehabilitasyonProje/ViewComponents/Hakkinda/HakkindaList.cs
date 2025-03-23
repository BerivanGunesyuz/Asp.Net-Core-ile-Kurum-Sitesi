using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace RehabilitasyonProje.ViewComponents.Hakkinda
{
    public class HakkindaList: ViewComponent
    {
        HakkindaManager hakkindaManager = new HakkindaManager(new EfHakkindaDal());
        public IViewComponentResult Invoke()
        {
            var values = hakkindaManager.GetList();
            return View(values);
        }
    }
}
