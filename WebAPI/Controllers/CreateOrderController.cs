using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CreateOrderController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        //Get All DATA Create Orders
        [HttpGet]
        [Route("Api/Order/GetOrders")]
        public List<Createorder> GetOrders()
        {
            List<Createorder> itemsorders = new List<Createorder>();
            itemsorders = db.Createorders.ToList();
            return itemsorders;
        }



        //Get Order Details

        [HttpGet]
        [Route("Api/Order/GetOrder")]
        public Createorder GetOrder(int id)
        {
            return db.Createorders.Where(a => a.Oid == id).FirstOrDefault();
        }


        //Create Order
        [HttpPost]
        [Route("Api/Order/CreateOrd")]

        public Createorder CreateOrd([FromBody] Createorder it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Createorders.Add(it);
            sp.SaveChanges();
            return it;
        }
    }
}
