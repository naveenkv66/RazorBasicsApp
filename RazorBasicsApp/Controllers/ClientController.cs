using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RazorBasicsApp.Models;

namespace RazorBasicsApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult NewClient()
        {
            var client = new Client();
            client.EmailPromos = new List<EmailPromo>()
            {
                new EmailPromo(){Id =1,IsSubscribed = false,Title = "Weekly Deal"},
                new EmailPromo(){Id =2,IsSubscribed = false,Title = "Holidays Promos"},
                new EmailPromo(){Id =3,IsSubscribed = false,Title = "Company NewsLetter"},
                new EmailPromo(){Id =4,IsSubscribed = false,Title = "New Product"}
            };
            return View(client);
        }
        [HttpPost]
        public ActionResult NewClient(Client client)
        {
            //save to Database

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");

            }
            return View(client);
        }

        public IActionResult VerifyEmail(string email)
        {            
            List<string> emails = new List<string>()
            {
                "test1@test.com",
                "test2@test.com",
                "test3@test.com",
                "test3@test.com"
            };
            if (!emails.Contains(email))
            {
                return Json(true);
            }
            return Json("Email is already taken");
        }


        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}