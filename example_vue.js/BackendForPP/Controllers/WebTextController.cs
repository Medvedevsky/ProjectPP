using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendForPP.Services;

using BackendForPP.Models;


namespace BackendForPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebTextController : ControllerBase
    {
        private WebService _service;
        public WebTextController(WebService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetData());
        }

        [HttpPost]
        public IActionResult Post([FromBody]WebText text)
        {
            return Ok(_service.PostText(text));
        }
    }
}
