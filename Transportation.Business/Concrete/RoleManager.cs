using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Business.Abstract;
using Transportation.Data.Repository.Abstract;
using Transportation.Data.Repository.Concrete;
using TransportationEntity;

namespace Transportation.Business.Concrete
{
    public  class RoleManager: ManagerBase<Role>,IRoleManager
    {
        private readonly IRoleRepository _repository;
        public RoleManager()
        {
            _repository = new RoleRepository();
        }
    }
}
