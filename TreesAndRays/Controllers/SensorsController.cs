using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TreesAndRays.Data;
using TreesAndRays.Models;
using TreesAndRays.Services;
//using TreesAndRays.Models

namespace TreesAndRays.Controllers
{
    public class SensorsController : Controller
    {
        public readonly IdbContext _context;
        public SensorsController(IdbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("SaveSensorsData")]
        public async Task<IActionResult> SaveSensorsData([FromBody] SensorsOutput request)
        {
            if (request != null) 
            {
                var sensorsData = new SensorsData
                {
                    TempCelsius = request.TempCelsius,
                    TempFahrenheit = request.TempFahrenheit,
                    HumidityPercentage = request.HumidityPercentage,
                    Moisture = request.Moisture,
                    MoisturePercentage = request.MoisturePercentage,
                    CreatedDate = DateTime.Now,
                };
                _context.SensorsData.Add(sensorsData);
            }                  
            _context.SaveChanges();
            return Ok("Inserted Successfully");
        }
        [HttpGet("GetSensorsData")]
        public async Task<IActionResult> GetSensorsData()
        {
            var SensorsData = _context.SensorsData.OrderByDescending(sd => sd.Id).FirstOrDefault();
            return Ok(SensorsData);
        }
        [HttpPost("SaveDeviceDataControl")]
        public async Task<IActionResult> SaveDeviceDataControl([FromBody] DeviceDataControl request)
        {
            if (request != null)
            {
                var DeviceDataControl = new DeviceDataControl
                {
                    MacId = request.MacId,
                    Status = request.Status                    
                };
                _context.DeviceDataControl.Add(DeviceDataControl);
            }
            _context.SaveChanges();
            return Ok("Inserted Successfully");
        }
        [HttpGet("GetDeviceDataControl")]
        public async Task<IActionResult> GetDeviceDataControl(string Macid)
        {
            //testing
            var DeviceDataControlStatus = _context.DeviceDataControl.Where(a => a.MacId == Macid).Select(a => a.Status).SingleOrDefault(); ;
            return Ok(DeviceDataControlStatus);
        }
    }
}
