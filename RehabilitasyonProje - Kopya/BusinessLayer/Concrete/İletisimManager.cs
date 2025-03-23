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
    public class İletisimManager : IİletisimService
    {
        IIletisimDal _iletisimDal;

        public İletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public List<İletisim> GetList()
        {
          return _iletisimDal.GetList();    
        }

        public void TAdd(İletisim t)
        {
           _iletisimDal.Insert(t);
        }

        public void TDelete(İletisim t)
        {
            _iletisimDal.Delete(t);
        }

        public İletisim TGetById(int id)
        {
           return _iletisimDal.GetByID(id); 
        }

        public void TUpdate(İletisim t)
        {
           _iletisimDal.Update(t);
        }
    }
}
