using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;

namespace RehabilitasyonProje.ViewComponents.İletisim
{
    public class SendMessage : ViewComponent
    {
        İletisimManager _iletisimManager = new İletisimManager(new EfİletisimDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(İletisim t)
        //{
        //    t.GonderimTarihi=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    _iletisimManager.TAdd(t);

        //    return View();
        //}

    }
}
