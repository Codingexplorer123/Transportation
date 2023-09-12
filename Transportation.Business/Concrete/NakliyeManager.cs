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
    public class NakliyeManager : ManagerBase<Nakliye>, INakliyeManager
    {
        //private readonly INakliyeRepository _repository;
        //public NakliyeManager(NakliyeRepository repository) : base(repository)
        //{
        //    _repository = repository;
        //}
    }
}
