using DemoAssessment.Services;
using DemoAssessmentAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAssessmentAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [ApiController]
    [Route("[controller]")]
    public class ManufacturerController : ControllerBase
    {
     
        private readonly IManufacturerService _manufacurerService;
        public ManufacturerController(ILogger<ManufacturerController> logger)
        {
            _manufacurerService = new ManufacturerService();
        }
        [HttpGet("GetManufacturers")]
        public IEnumerable<Manufacturer> Get()
        {
            var list = _manufacurerService.GetManufacturers();
            return list;
        }


        [HttpPost("AddManufacturer")]
        public IEnumerable<Manufacturer> AddManufacturer(string manufacturerName, String countryName)
        {


            var list = _manufacurerService.GetManufacturers();
            return list;
        }
    }
}
