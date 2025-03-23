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
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public List<Ogrenci> GetList()
        {
            return _ogrenciDal.GetList();   
        }

        public void TAdd(Ogrenci t)
        {
            _ogrenciDal.Insert(t);  
        }

        public void TDelete(Ogrenci t)
        {
           _ogrenciDal.Delete(t);
        }

        public Ogrenci TGetById(int id)
        {
            return _ogrenciDal.GetByID(id);
        }

        public void TUpdate(Ogrenci t)
        {
            _ogrenciDal.Update(t);
        }
    }
}
