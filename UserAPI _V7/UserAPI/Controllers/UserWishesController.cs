using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserAPI;
using UserAPI.Model;

namespace UserAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/UserWishes")]
    [ApiController]
    public class UserWishesController : ControllerBase
    {
        private readonly UserContext _context;

        private UserLogic manager = new UserLogic();

        public UserWishesController(UserContext context)
        {
            _context = context;
        }


        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task /*<ActionResult<UserWish>>*/ PostUserWish(UserWish userWish)
        {
            /* _context.UserWishes.Add(userWish);
             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateException)
             {
                 if (UserWishExists(userWish.ID))
                 {
                     throw new HttpResponseException(HttpStatusCode.BadRequest);
                 }
                 else
                 {
                     throw;
                 }
             }*/

            manager.RegisterWish(userWish);
           /* {
                throw new HttpResponseException(HttpStatusCode.Accepted); // send this status code to tier 1
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }*/

            // return CreatedAtAction("GetUserWish", new { id = userWish.ID }, userWish);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("{id}")]
        public async Task /*<ActionResult<UserWish>>*/ RemoveUserWish(UserWish userWish)
        {
            /* _context.UserWishes.Add(userWish);
             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateException)
             {
                 if (UserWishExists(userWish.ID))
                 {
                     throw new HttpResponseException(HttpStatusCode.BadRequest);
                 }
                 else
                 {
                     throw;
                 }
             }*/

            manager.DeleteWish(userWish);
            /* {
                 throw new HttpResponseException(HttpStatusCode.Accepted); // send this status code to tier 1
             }
             else
             {
                 throw new HttpResponseException(HttpStatusCode.BadRequest);
             }*/

            // return CreatedAtAction("GetUserWish", new { id = userWish.ID }, userWish);
        }





        // GET: api/UserWishes
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<ActionResult<IEnumerable<UserWish>>> GetUserWishes()
        {
            return await _context.UserWishes.ToListAsync();
        }

        // GET: api/UserWishes/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public async Task<ActionResult<UserWish>> GetUserWish(string id)
        {
            var userWish = await _context.UserWishes.FindAsync(id);

            if (userWish == null)
            {
                return NotFound();
            }

            return userWish;
        }

        // PUT: api/UserWishes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public async Task<IActionResult> PutUserWish(string id, UserWish userWish)
        {
            if (id != userWish.ID)
            {
                return BadRequest();
            }

            _context.Entry(userWish).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserWishExists(id))
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


        // DELETE: api/UserWishes/5
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public async Task<ActionResult<UserWish>> DeleteUserWish(string id)
        {
            var userWish = await _context.UserWishes.FindAsync(id);
            if (userWish == null)
            {
                return NotFound();
            }

            _context.UserWishes.Remove(userWish);
            await _context.SaveChangesAsync();

            manager.DeleteWish(userWish);

            return userWish;
        }

        private bool UserWishExists(string id)
        {
            return _context.UserWishes.Any(e => e.ID == id);
        }
    }
}