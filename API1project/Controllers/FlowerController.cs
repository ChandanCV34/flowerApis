using API1project.Models;
using API1project.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API1project.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
        private readonly FlowerService _service;

        public FlowerController(FlowerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<flower>> Post([FromBody] flower order)
        {
            flower orders = _service.Add(order);
            if (orders != null)
            {
                return orders;
            }
            return BadRequest("Couldnt Add");
        }



    }
}
