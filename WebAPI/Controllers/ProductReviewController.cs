using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductReviewController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();


        //Get Single ProductReview Details
        [HttpGet]
        [Route("Api/ProductReview/GetProductReview")]
        public List<Productreview> GetProductReview(int id)
        {
            return db.Productreviews.Where(a => a.Oid == id).ToList();
        }


        //Add ProductReview
        [HttpPost]
        [Route("Api/ProductReview/AddingProductReview")]

        public Productreview AddingProductReview([FromBody] Productreview it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Productreviews.Add(it);
            sp.SaveChanges();
            return it;
        }
    }
}
