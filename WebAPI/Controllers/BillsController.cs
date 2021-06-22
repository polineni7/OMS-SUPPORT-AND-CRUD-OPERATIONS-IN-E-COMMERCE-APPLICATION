using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class BillsController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();


        //Get Single Bill Details
        [HttpGet]
        [Route("Api/Bill/GetBill")]
        public List<Bill> GetBill(int id)
        {
            return db.Bills.Where(a => a.Billid == id).ToList();
        }


        //Add Bill
        [HttpPost]
        [Route("Api/Bill/AddingBill")]

        public Bill AddingBill([FromBody] Bill it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Bills.Add(it);
            sp.SaveChanges();
            return it;
        }
    }
}
