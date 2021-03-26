using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mariadbapp.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace mariadbapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly test1Context _context;

        public UsersController(test1Context context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MdlxgUser>>> GetMdlxgUser()
        {
            return await _context.MdlxgUser.ToListAsync();
        }

        [HttpGet]
        [Route("api/getuserbycourseid/{id}")]
        public List<UsersByCourse> GetUserByCourseID(int id)
        {
            

            return  _context.MdlxgUser.Join(
                _context.MdlxgUserLastaccess,
                MdlxgUser => MdlxgUser.Id,
                MdlxgUserLastaccess => MdlxgUserLastaccess.Userid,
                (MdlxgUser, MdlxgUserLastaccess) => new UsersByCourse
                {
                    username = MdlxgUser.Username,
                    firstname = MdlxgUser.Firstname,
                    lastname = MdlxgUser.Lastname,
                    courseid = MdlxgUserLastaccess.Courseid
                }
                ).Where(cid=>cid.courseid==id)
                .ToList();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MdlxgUser>> GetMdlxgUser(long id)
        {
            var mdlxgUser = await _context.MdlxgUser.FindAsync(id);

            if (mdlxgUser == null)
            {
                return NotFound();
            }

            return mdlxgUser;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMdlxgUser(long id, MdlxgUser mdlxgUser)
        {
            if (id != mdlxgUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(mdlxgUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MdlxgUserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MdlxgUser>> PostMdlxgUser(MdlxgUser mdlxgUser)
        {
            _context.MdlxgUser.Add(mdlxgUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMdlxgUser", new { id = mdlxgUser.Id }, mdlxgUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MdlxgUser>> DeleteMdlxgUser(long id)
        {
            var mdlxgUser = await _context.MdlxgUser.FindAsync(id);
            if (mdlxgUser == null)
            {
                return NotFound();
            }

            _context.MdlxgUser.Remove(mdlxgUser);
            await _context.SaveChangesAsync();

            return mdlxgUser;
        }

        private bool MdlxgUserExists(long id)
        {
            return _context.MdlxgUser.Any(e => e.Id == id);
        }
    }
}
