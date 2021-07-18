using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfitecDetran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Teste OK";
        }
    }
}
