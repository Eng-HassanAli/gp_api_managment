using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IntelligenceFarmer.tableDb;

namespace IntelligenceFarmer.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private GpDbContext gpDb;
        public UserController(GpDbContext gpDB)
        {
            this.gpDb = gpDB;

        }
        //  [HttpGet("{username}/{password}")]
        ////[HttpGet]
        //  public ActionResult<IEnumerable<Users>> login(string username,string password)
        //  {
        //      var user = gpDb.user.Where(x => x.UserName.Equals(username) &&x.Password_Number.Equals(password)).FirstOrDefault();
        //      if (user != null)
        //          return Ok(user);
        //      else
        //          return BadRequest();

        //  }
        [HttpGet("{username}/{password}")]
        public ActionResult<IEnumerable<Users>> login(string username, string password)
        {
            var user = gpDb.user.Where(x => x.UserName.Equals(username)&& x.Password_Number.Equals(password)).FirstOrDefault();
            if (user != null)
                return Ok(user);
            else
                return BadRequest("try.....");

        }
    }
}