using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeviceService
    {
        IDataResult<List<Device>> GetAll();
        IResult Add(Device device);
        IResult Update(Device device);
        IResult Delete(Device device);
    }
}
