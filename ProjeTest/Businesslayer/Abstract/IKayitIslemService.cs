using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IKayitIslemService
    {
        void AddKayitIslem(KayitSistemi kayitSistemi);
        void DeleteKayitIslem(KayitSistemi kayitSistemi);
        void UpdateKayitIslem(KayitSistemi kayitSistemi);
        List<KayitSistemi> GetList();
        KayitSistemi GetById(int id);
    }
}
