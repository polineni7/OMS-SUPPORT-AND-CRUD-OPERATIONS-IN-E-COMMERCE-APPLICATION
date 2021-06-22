using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ShippingController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();
        //Get Shipping Details
        [HttpGet]
        [Route("Api/Shipping/GetShipping")]
        public List<Shipingdetail> GetShipping(int id)
        {
            return db.Shipingdetails.Where(a => a.Oid == id).ToList();
        }


        //Add AddingShipping
        [HttpPost]
        [Route("Api/Shipping/AddingShipping")]

        public Shipingdetail AddingShipping([FromBody] Shipingdetail it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Shipingdetails.Add(it);
            sp.SaveChanges();
            return it;
        }

    }
}
