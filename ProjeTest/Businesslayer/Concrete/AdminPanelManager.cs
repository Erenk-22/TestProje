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
    public class AdminPanelManager : IAdminPanelService
    {
        IAdminPanelDal _adminpanel;

        public AdminPanelManager(IAdminPanelDal admin)
        {
            _adminpanel = admin;
        }
        public void AddAdminPanel(AdminPanel admin)
        {
            _adminpanel.Insert(admin);
        }
    }
}
