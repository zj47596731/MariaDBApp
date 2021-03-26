using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mariadbapp.Models;

namespace mariadbapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly test1Context _context;

        public CoursesController(test1Context context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MdlxgCourse>>> GetMdlxgCourse()
        {
            return await _context.MdlxgCourse.ToListAsync();
        }

        [HttpGet]
        [Route("api/getcoursebyid/{id}")]
        public async Task<ActionResult<IEnumerable<MdlxgCourse>>> GetMdlxgCoursebyCategory(int id)
        {
            return await _context.MdlxgCourse
                .Where(cid => cid.Category == id)
                .ToListAsync();
        }
        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MdlxgCourse>> GetMdlxgCourse(long id)
        {
            var mdlxgCourse = await _context.MdlxgCourse.FindAsync(id);

            if (mdlxgCourse == null)
            {
                return NotFound();
            }

            return mdlxgCourse;
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMdlxgCourse(long id, MdlxgCourse mdlxgCourse)
        {
            if (id != mdlxgCourse.Id)
            {
                return BadRequest();
            }

            _context.Entry(mdlxgCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MdlxgCourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Courses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MdlxgCourse>> PostMdlxgCourse(MdlxgCourse mdlxgCourse)
        {
            _context.MdlxgCourse.Add(mdlxgCourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMdlxgCourse", new { id = mdlxgCourse.Id }, mdlxgCourse);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MdlxgCourse>> DeleteMdlxgCourse(long id)
        {
            var mdlxgCourse = await _context.MdlxgCourse.FindAsync(id);
            if (mdlxgCourse == null)
            {
                return NotFound();
            }

            _context.MdlxgCourse.Remove(mdlxgCourse);
            await _context.SaveChangesAsync();

            return mdlxgCourse;
        }

        private bool MdlxgCourseExists(long id)
        {
            return _context.MdlxgCourse.Any(e => e.Id == id);
        }
    }
}
