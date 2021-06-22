using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class OrdersheetController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();


        //Get Single OrderSheet Details
        [HttpGet]
        [Route("Api/Odersheet/GetOrdersheet")]
        public List<Ordersheet> GetOrdersheet(int id)
        {
            return db.Ordersheets.Where(a => a.Oid == id).ToList();
        }



        //Create OrderSheet
        [HttpPost]
        [Route("Api/Ordercreate/Sheet")]
        public Ordersheet sheet([FromBody] Ordersheet re)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Ordersheets.Add(re);
            sp.SaveChanges();
            return re;
        }
    }
}
