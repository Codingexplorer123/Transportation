using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Business.Abstract;
using Transportation.Data.Repository.Abstract;
using TransportationEntity;

namespace Transportation.Business.Concrete
{
    public class UserManager : ManagerBase<User>, IUserManager
    {
        private readonly IUserRepository _repository;

        public  UserManager(IUserRepository repository) :base(repository)
        {
            _repository = repository;
        }
    }
}
