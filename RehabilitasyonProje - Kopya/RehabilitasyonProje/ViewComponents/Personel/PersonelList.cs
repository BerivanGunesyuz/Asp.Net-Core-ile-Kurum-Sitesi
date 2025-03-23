using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace RehabilitasyonProje.ViewComponents.Personel
{
    public class PersonelList: ViewComponent
    {
        PersonelManager _personelManager = new PersonelManager(new EfPersonelDal());
        public IViewComponentResult Invoke()
        {
           var values= _personelManager.GetList();
            return View(values); }    
    }
}
