using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorBasicsApp.Models;

namespace RazorBasicsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Order> orders = new List<Order>()
            {
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-3), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-8), Description = "Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-5), Description = "Maecenas sed diam eget risus varius blandit. Maecenas sed diam eget risus varius blandit. Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." },
                new Order() { Name = "Donec id elit non", LastUpdated = DateTime.Now.AddDays(-15), Description = "Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit." }

            };
            ViewBag.orders = orders;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
