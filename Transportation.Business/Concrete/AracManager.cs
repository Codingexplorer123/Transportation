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
    public class AracManager : ManagerBase<Arac>, IAracManager
    {
        private readonly IAracRepository _repository;
        public AracManager() 
        {
            _repository = new AracRepository();
        }

        
    }
}
