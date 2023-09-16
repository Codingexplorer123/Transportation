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
    public class UserManager : ManagerBase<MyUser>, IUserManager
    {
        private readonly IUserRepository _repository;

        public  UserManager()
        {
            _repository = new UserRepository();
        }

        // Repository Pattern disinda Asp.net core identity paketini yuklemedigimizden dolayi ordaki Sign in manager, user manager yaptigi
        // is kurallarini biz burda default methodlarla tanimlamaya calisacagiz

        public async Task<MyUser?> LoginKontrol(string email, string password)
        {
            var user = await _repository.GetBy(p=>p.Email == email && p.Password== password);
            // kullanicinin girdigi email ve password databasedeki verilerle karsilastiriliyor.
            if(user != null)
            {
                return user;
            }
            return null;
        }
        


    }
}
