using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WEB_API___First.Data;
using WEB_API___First.Models;
using WEB_API___First.DTOS.Students;

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
            List<StudentForListDto> studentForListDtos = await _context.Students.Where(s => s.Isdeleted == false)
                .Select(
                x => new StudentForListDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname
                }
                ).ToListAsync();

            return Ok(studentForListDtos);
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
        public async Task<IActionResult> Post(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            student.CreatedAt = DateTime.UtcNow.AddHours(+4);
            student.CreatedBy = "System";

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int? id , Student student)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id == null) return BadRequest();

            Student Dbstudent = await _context.Students.FirstOrDefaultAsync(s => s.Id == id && s.Isdeleted == false);

            if (Dbstudent == null) return NotFound();
            Dbstudent.Name = student.Name;
            Dbstudent.Surname = student.Surname;
            Dbstudent.UpdateAt = DateTime.UtcNow.AddHours(+4);
            Dbstudent.UpdateBy = "SystemUPD";

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public async  Task<IActionResult> Delete(int? id) 
        {
            if (id == null) return BadRequest();

            Student student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id && s.Isdeleted == false);

            if (student == null) return NotFound();

            student.Isdeleted = true;
            student.DeletedAt = DateTime.UtcNow.AddHours(+4);
            student.DeletedBy = "Sytemdeleted";

            await _context.SaveChangesAsync();

            return NoContent();
        }
        
    }
}
