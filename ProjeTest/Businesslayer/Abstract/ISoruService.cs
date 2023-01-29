using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public  interface ISoruService
    {
        void AddSoru(UyeSorülar uyeSorülar);
        void DeleteSoru(UyeSorülar uyeSorülar);
        void UpdateSoru(UyeSorülar uyeSorülar);
        List<UyeSorülar> GetList();
        UyeSorülar GetById(int id);
    }
}
