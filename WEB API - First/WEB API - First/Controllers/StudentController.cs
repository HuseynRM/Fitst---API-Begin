using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API___First.Data;
using WEB_API___First.Models;

namespace WEB_API___First.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Students.ToListAsync());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null) return BadRequest();

            Student student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id && s.Isdeleted == false);

            if (student == null) return NotFound();
            
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Post()
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
