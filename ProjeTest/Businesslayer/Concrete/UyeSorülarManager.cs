using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class UyeSorülarManager : ISoruService
    {
        IUyeSorülarDal _UyeSorülarDal;

        public UyeSorülarManager(IUyeSorülarDal uyeSorülar)
        {
            _UyeSorülarDal = uyeSorülar;
        }
        public void AddSoru(UyeSorülar uyeSorülar)
        {
            _UyeSorülarDal.Insert(uyeSorülar);
        }

        public void DeleteSoru(UyeSorülar uyeSorülar)
        {
            _UyeSorülarDal.Delete(uyeSorülar);
        }

        public UyeSorülar GetById(int id)
        {
            return _UyeSorülarDal.GetById(id);
        }

        public List<UyeSorülar> GetList()
        {
            return _UyeSorülarDal.List();
        }

        public void UpdateSoru(UyeSorülar uyeSorülar)
        {
            _UyeSorülarDal.Update(uyeSorülar);
        }
    }
}
