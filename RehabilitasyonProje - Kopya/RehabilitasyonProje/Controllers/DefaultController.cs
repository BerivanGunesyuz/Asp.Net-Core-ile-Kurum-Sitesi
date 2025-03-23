using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RehabilitasyonProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial() {
            return PartialView();
        }

        public PartialViewResult NavbarPartial () {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage () {
            return PartialView();
        } 
        [HttpPost]
        public PartialViewResult SendMessage (İletisim t) 
        {
            İletisimManager _iletisimManager = new İletisimManager(new EfİletisimDal());
            t.GonderimTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _iletisimManager.TAdd(t);

            return PartialView();
        }
    }
}
