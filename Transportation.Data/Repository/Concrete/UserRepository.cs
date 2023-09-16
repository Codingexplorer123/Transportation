using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Data.Repository.Abstract;
using TransportationEntity;

namespace Transportation.Data.Repository.Concrete
{
    public class UserRepository: BaseRepository<MyUser>,IUserRepository
    {
    }
}
