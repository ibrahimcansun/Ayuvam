using Business.Abstract;
using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DeviceManager : IDeviceService
    {
        //TODO
        public IResult Add(Device device)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Device device)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Device>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Device device)
        {
            throw new NotImplementedException();
        }
    }
}
