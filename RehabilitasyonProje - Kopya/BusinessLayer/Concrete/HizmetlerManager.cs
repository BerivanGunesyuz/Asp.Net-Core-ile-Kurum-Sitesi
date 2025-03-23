using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HizmetlerManager : IHizmetlerService
    {
        IHizmetlerDal _hizmetDal;

        public HizmetlerManager(IHizmetlerDal hizmetDal)
        {
            _hizmetDal = hizmetDal;
        }

        public List<Hizmetler> GetList()
        {
           return _hizmetDal.GetList(); 
        }

        public void TAdd(Hizmetler t)
        {
            _hizmetDal.Insert(t);
        }

        public void TDelete(Hizmetler t)
        {
           _hizmetDal.Delete(t);
        }

        public Hizmetler TGetById(int id)
        {
            return _hizmetDal.GetByID(id);  
        }

        public void TUpdate(Hizmetler t)
        {
         _hizmetDal.Update(t);  
        }
    }
}
