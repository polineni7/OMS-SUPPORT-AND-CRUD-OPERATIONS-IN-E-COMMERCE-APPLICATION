using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class VendorController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        //Get All DATA Vendors
        [HttpGet]
        [Route("Api/Vendor/GetVendors")]
        public List<Vendor> GetVendors()
        {
            List<Vendor> ven = new List<Vendor>();
            ven = db.Vendors.ToList();
            return ven;
        }



        //Get Single Vendor Details

        [HttpGet]
        [Route("Api/Vendor/GetVendor")]
        public Vendor GetVendor(int id)
        {
            return db.Vendors.Where(a => a.Vid == id).FirstOrDefault();
        }


        //Create Vendor
        [HttpPost]
        [Route("Api/Vendor/CreateVen")]

        public Vendor CreateVen([FromBody] Vendor it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Vendors.Add(it);
            sp.SaveChanges();
            return it;
        }

    }
}
