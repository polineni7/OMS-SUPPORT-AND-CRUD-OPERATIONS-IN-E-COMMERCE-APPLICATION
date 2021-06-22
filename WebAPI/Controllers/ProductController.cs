using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        //Get All DATA Products
        [HttpGet]
        [Route("Api/Product/GetProducts")]
        public List<Product> GetProducts()
        {
            List<Product> pt = new List<Product>();
            pt = db.Products.ToList();
            return pt;
        }



        //Get Single Product Details

        [HttpGet]
        [Route("Api/Product/GetProduct")]
        public Product GetProduct(int id)
        {
            return db.Products.Where(a => a.Id == id).FirstOrDefault();
        }


        //Adding Products
        [HttpPost]
        [Route("Api/Product/AddingProduct")]

        public Product AddingProduct([FromBody] Product it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Products.Add(it);
            sp.SaveChanges();
            return it;
        }

    }
}
