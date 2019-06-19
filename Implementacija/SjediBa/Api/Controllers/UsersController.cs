using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SjediBa.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> Get()
        {
            List<UserModel> users = new List<UserModel>();
            using(var db = new DatabaseContext()) {
                users = db.korisnici.ToList();
            }
            return users;
            // return null;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<UserModel> Get(int id)
        {
            // UserModel user = new UserModel();
            // UserModel user = null;
            UserModel user;
            using(var db = new DatabaseContext()) {
                user = db.korisnici.Where(k => k.UserModelId == id).FirstOrDefault();
            }

            if (user == null) {
                return NotFound();
            }

            return user;
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] UserModel value)
        {
            using(var db = new DatabaseContext()) {
                db.korisnici.Add(value);
                db.SaveChanges();
            }
        }

        // PUT api/users/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] UserModel value)
        // {
        //     using(var db = new DatabaseContext()) {
        //         if (id != value.UserModelId) {
        //             return BadRequest();
        //         }
        //         db.Entry(value).State = EntityState.Modified;
        //         db.SaveChanges();
        //     }
        // }

        // PUT api/users
        [HttpPut]
        public void Put([FromBody] UserModel value)
        {
            using(var db = new DatabaseContext()) {
                UserModel user = db.korisnici.Where(k => k.UserModelId == value.UserModelId).FirstOrDefault();
                if (user == null) {
                    // return NotFound();
                }
                user.Name = value.Name;
                user.Surname = value.Surname;
                user.Address = value.Address;
                user.DateOfBirth = value.DateOfBirth;
                db.SaveChanges();
            }
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using(var db = new DatabaseContext()) {
                UserModel user = db.korisnici.Where(k => k.UserModelId == id).FirstOrDefault();
                if (user == null) {
                    // return NotFound();
                }
                db.korisnici.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
