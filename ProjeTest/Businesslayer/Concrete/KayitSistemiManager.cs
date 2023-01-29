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
    public class KayitSistemiManager : IKayitIslemService
    {
        IKayitIslemDal _kayitIslem;

        public KayitSistemiManager(IKayitIslemDal kayitIslem)
        {
            _kayitIslem = kayitIslem;
        }

        public void AddKayitIslem(KayitSistemi kayitSistemi)
        {
            _kayitIslem.Insert(kayitSistemi);
        }


        public void DeleteKayitIslem(KayitSistemi kayitSistemi)
        {
            _kayitIslem.Delete(kayitSistemi);
        }

        public KayitSistemi GetById(int id)
        {
            return _kayitIslem.Get(x=>x.UyeID==id);
        }

        public List<KayitSistemi> GetList()
        {
            return _kayitIslem.List();
        }

        public void UpdateKayitIslem(KayitSistemi kayitSistemi)
        {
            _kayitIslem.Update(kayitSistemi);
        }
    }
}
