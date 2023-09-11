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
    public class RezervasyonManager:ManagerBase<Rezervasyon>,IRezervasyonManager
    {
        private readonly IRezervasyonRepository _repository;
        public RezervasyonManager(IRezervasyonRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
