using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    public class clientswrapper
    {
        public Client clt { get; set; }
        public String result { get; set; }


    }
    public class ClientController : Controller
    {
        BitAppsOMSContext db = new BitAppsOMSContext();

        [HttpGet]
        [Route("api/client/GetClientsinfo")]
        
        public List<Client> GetClientsinfo()
        {
            List<Client> ct = new List<Client>();
            ct = db.Clients.ToList();
            return ct;
        }

        //Get Single Client Details

        [HttpGet]
        [Route("Api/Client/GetClient")]
        public Client GetClient(int id)
        {
            return db.Clients.Where(a => a.Id == id).FirstOrDefault();
        }


        //Add Client

        [HttpPost]
        [Route("Api/Client/AddingClient")]

        public Client AddingClient([FromBody] Client it)
        {
            BitAppsOMSContext sp = new BitAppsOMSContext();
            sp.Clients.Add(it);
            sp.SaveChanges();
            return it;
        }


        //Update Client
        [HttpPost]
        [Route("Api/Client/UpdateClient")]
        public Client UpdateClient([FromBody] Client ct)
        {
            var du = db.Clients.Where(a => a.Id == ct.Id).FirstOrDefault();
            du.Cname = ct.Cname;
            du.Email = ct.Email;
            du.Phone = ct.Phone;
            du.Caddress = ct.Branch;
            du.Branch = ct.Branch;
            du.Cdescription = ct.Cdescription;
            du.Cothernotes = ct.Cothernotes;
            db.SaveChanges();
            return ct;
        }


        //Delete Client
        [HttpPost]
        [Route("Api/Client/DeleteClient")]
        public clientswrapper DeleteClient([FromBody] clientswrapper ct, int id)
        {
            BitAppsOMSContext db = new BitAppsOMSContext();
            String msg = "";
            try
            {
                var del = db.Clients.Where(a => a.Id == id).FirstOrDefault();
                if (del != null)
                {
                    db.Clients.Remove(del);
                    db.SaveChanges();
                    msg = "ok";
                }
                msg = "not exists";
            }
            catch (Exception ee)
            {
                msg = ee.Message;
            }
            ct.result = msg;
            return ct;
        }
    }
}
