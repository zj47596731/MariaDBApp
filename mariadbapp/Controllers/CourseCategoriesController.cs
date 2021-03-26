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
    public class CourseCategoriesController : ControllerBase
    {
        private readonly test1Context _context;

        public CourseCategoriesController(test1Context context)
        {
            _context = context;
        }

        // GET: api/CourseCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MdlxgCourseCategories>>> GetMdlxgCourseCategories()
        {
            return await _context.MdlxgCourseCategories
                .Where(pid=>pid.Parent==0)
                .ToListAsync();
        }

        [HttpGet]
        [Route("api/getcoursebyid/{id}")]
        public async Task<ActionResult<IEnumerable<MdlxgCourseCategories>>> GetMdlxgCoursewithID(int id)
        {
            return await _context.MdlxgCourseCategories
                .Where(pid => pid.Parent == id)
                .ToListAsync();
        }

        // GET: api/CourseCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MdlxgCourseCategories>> GetMdlxgCourseCategories(long id)
        {
            var mdlxgCourseCategories = await _context.MdlxgCourseCategories.FindAsync(id);

            if (mdlxgCourseCategories == null)
            {
                return NotFound();
            }

            return mdlxgCourseCategories;
        }

        // PUT: api/CourseCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMdlxgCourseCategories(long id, MdlxgCourseCategories mdlxgCourseCategories)
        {
            if (id != mdlxgCourseCategories.Id)
            {
                return BadRequest();
            }

            _context.Entry(mdlxgCourseCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MdlxgCourseCategoriesExists(id))
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

        // POST: api/CourseCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MdlxgCourseCategories>> PostMdlxgCourseCategories(MdlxgCourseCategories mdlxgCourseCategories)
        {
            _context.MdlxgCourseCategories.Add(mdlxgCourseCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMdlxgCourseCategories", new { id = mdlxgCourseCategories.Id }, mdlxgCourseCategories);
        }

        // DELETE: api/CourseCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MdlxgCourseCategories>> DeleteMdlxgCourseCategories(long id)
        {
            var mdlxgCourseCategories = await _context.MdlxgCourseCategories.FindAsync(id);
            if (mdlxgCourseCategories == null)
            {
                return NotFound();
            }

            _context.MdlxgCourseCategories.Remove(mdlxgCourseCategories);
            await _context.SaveChangesAsync();

            return mdlxgCourseCategories;
        }

        private bool MdlxgCourseCategoriesExists(long id)
        {
            return _context.MdlxgCourseCategories.Any(e => e.Id == id);
        }
    }
}
