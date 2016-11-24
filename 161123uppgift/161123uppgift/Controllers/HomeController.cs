using _161123uppgift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace _161123uppgift.Controllers
{
    public class HomeController : Controller
    {

        private CloudStorageAccount storageAccount;
        private CloudTableClient tableClient;
        private CloudTable table;

        public HomeController()
        {
            storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;");
            tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("LocalTable");
            table.CreateIfNotExists();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(GuestResponse g)
        {
            //MVC använder Model Binding för att tolka datat från POST
            //till vad vi förväntar oss, dvs ett GuestResponse Object/Entity
            //Model binding binder ihop, mappar, propertyn Name med värdet Name

            //Vi vill veta om svaret uppfyller modellens krav
            if (ModelState.IsValid == true)
            {
                GuestResponse person = new GuestResponse(Guid.NewGuid().ToString()) { Name = g.Name, Phone = g.Phone };
                
                // Create the TableOperation object that inserts the customer entity.
                TableOperation insertOperation = TableOperation.Insert(person);
                
                // Execute the insert operation.
                table.Execute(insertOperation);

                return View("ThankYou", g);
            }

            //Om inte valid, dvs namn saknas, visa formuläret igen
            return View();
        }
    }
}