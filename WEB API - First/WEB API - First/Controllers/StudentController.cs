using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API___First.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int? id)
        {
            return Ok(id);
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Post !!!");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Put !!!");
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return NoContent();
        }
        
    }
}
