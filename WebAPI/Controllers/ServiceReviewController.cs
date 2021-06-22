using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ServiceReviewController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();


        //Get Single ServiceReview Details
        [HttpGet]
        [Route("Api/ServiceReview/GetServiceReview")]
        public List<Servicereview> GetServiceReview(int id)
        {
            return db.Servicereviews.Where(a => a.Oid == id).ToList();
        }


        //Add ServiceReview
        [HttpPost]
        [Route("Api/ServiceReview/AddingServiceReview")]

        public Servicereview AddingServiceReview([FromBody] Servicereview it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Servicereviews.Add(it);
            sp.SaveChanges();
            return it;
        }
    }
}
