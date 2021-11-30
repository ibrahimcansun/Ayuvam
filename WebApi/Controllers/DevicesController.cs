using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private IDeviceService _deviceService;
        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _deviceService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);

        }
        [HttpPost("add")]
        public IActionResult Add(Device device)
        {
            var result = _deviceService.Add(device);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);

        }
        [HttpPut("update")]
        public IActionResult Update(Device device)
        {
            var result = _deviceService.Update(device);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);

        }
        [HttpDelete("delete")]
        public IActionResult Delete(Device device)
        {
            var result = _deviceService.Delete(device);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);

        }
    }
}
