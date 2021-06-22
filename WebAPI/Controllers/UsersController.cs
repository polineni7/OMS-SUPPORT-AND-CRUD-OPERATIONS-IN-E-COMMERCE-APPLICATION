using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UsersController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        //Get All DATA Users
        [HttpGet]
        [Route("Api/Users/GetUsers")]
        public List<User> GetUsers()
        {
            List<User> ur = new List<User>();
            ur = db.Users.ToList();
            return ur;
        }



        //Get Single User Details

        [HttpGet]
        [Route("Api/Users/GetUser")]
        public User GetUser(int id)
        {
            return db.Users.Where(a => a.Id == id).FirstOrDefault();
        }


        //Adding Users
        [HttpPost]
        [Route("Api/Users/CreatUser")]

        public User CreatUser([FromBody] User it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Users.Add(it);
            sp.SaveChanges();
            return it;
        }

    }
}
