using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ReturnServicesController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        [HttpGet]
        [Route("api/Return/GetReturnsinfo")]

        public List<Returnservice> GetReturnsinfo()
        {
            List<Returnservice> ct = new List<Returnservice>();
            ct = db.Returnservices.ToList();
            return ct;
        }

        //Get Returnitems Details
        [HttpGet]
        [Route("Api/Return/GetReturnitems")]
        public List<Returnservice> GetReturnitems(int id)
        {
            return db.Returnservices.Where(a => a.Oid == id).ToList();
        }


        //Add Return
        [HttpPost]
        [Route("Api/Return/AddingReturns")]

        public Returnservice AddingReturns([FromBody] Returnservice it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Returnservices.Add(it);
            sp.SaveChanges();
            return it;
        }
    }
}
