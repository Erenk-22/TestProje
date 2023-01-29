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
    public class UyeCvManager : ICvService
    {
        IUyeCvDal _CV;

        public UyeCvManager(IUyeCvDal UyeCV)
        {
            _CV = UyeCV;
        }

        public void AddUyeCv(UyeCv uyeCv)
        {
            _CV.Insert(uyeCv);
        }
    }
}
