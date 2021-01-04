using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sampleapi.datacontext;
using sampleapi.model;
using sampleapi.ViewModel;

namespace sampleapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly Userdbcontext dbcontext;
       

        public UserController(Userdbcontext userdbcontext)
        {
            dbcontext = userdbcontext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return dbcontext.user.ToList();
        }
        [HttpGet("{full_name}")]
        public ActionResult<User> Getbyfullname(string full_name)
        {
            return dbcontext.user.FirstOrDefault(a => a.full_name == full_name);
        }
        [HttpPost]
        public ActionResult<User> Save(User user)
        {
            dbcontext.user.Add(user);
            dbcontext.SaveChanges();
            return user;
        }
        [HttpPut]
        public ActionResult<User> Update(User user)
        {
            User result = dbcontext.user.FirstOrDefault(x => x.user_id == user.user_id);
            if (result != null)
            {
                result.password = user.password;
                result.user_id = user.user_id;
                result.username = user.username;
                result.full_name = user.full_name;
                result.email = user.email;
                result.contact = user.contact;
                result.address = user.address;
                
            }
            dbcontext.SaveChanges();
            return result;
        }
        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            User result = dbcontext.user.FirstOrDefault(x => x.user_id == id);
            if (result != null)
            {
                dbcontext.Remove(result);

            }
            dbcontext.SaveChanges();
            return true;
           
        }



    }
}
