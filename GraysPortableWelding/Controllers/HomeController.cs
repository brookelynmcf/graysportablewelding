using GraysPortableWelding.Models;
using GraysPortableWelding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraysPortableWelding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ServicesViewModel servicesViewModel = new ServicesViewModel();
            servicesViewModel.Services = new List<Service>();
            Service service1 = new Service() { Description = "welding using a tungstene rod", Name = "tig", Price = 450.50 };
            Service service2 = new Service() { Description = "welding using a wire electrode", Name = "mig", Price = 550.50 };
            Service service3 = new Service() { Description = "welding using a stick", Name = "stick welding", Price = 650.50 };

            servicesViewModel.Services.Add(service1);
            servicesViewModel.Services.Add(service2);
            servicesViewModel.Services.Add(service3);


            return View(servicesViewModel);
        }

    }
}