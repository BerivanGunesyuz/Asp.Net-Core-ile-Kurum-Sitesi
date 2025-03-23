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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetList()
        {
          return _personelDal.GetList();    
        }

        public void TAdd(Personel t)
        {
           _personelDal.Insert(t);
        }

        public void TDelete(Personel t)
        {
            _personelDal.Delete(t);
        }

        public Personel TGetById(int id)
        {
            return _personelDal.GetByID(id);
        }

        public void TUpdate(Personel t)
        {
            _personelDal.Update(t);
        }
    }
}
