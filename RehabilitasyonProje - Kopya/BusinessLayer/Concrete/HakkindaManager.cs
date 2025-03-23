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
    public class HakkindaManager : IHakkindaService
    {
        IHakkindaDal _hakkindaDal;

        public HakkindaManager(IHakkindaDal hakkindaDal)
        {
            _hakkindaDal = hakkindaDal;
        }

        public List<Hakkinda> GetList()
        {
          return _hakkindaDal.GetList();
        }

        public void TAdd(Hakkinda t)
        {
            _hakkindaDal.Insert(t);
        }

        public void TDelete(Hakkinda t)
        {
            _hakkindaDal.Delete(t);
        }

        public Hakkinda TGetById(int id)
        {
            return _hakkindaDal.GetByID(id);
        }

        public void TUpdate(Hakkinda t)
        {
           _hakkindaDal.Update(t);
        }
    }
}
