using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDependencyTut.service;

namespace UnityDependencyTut.Controllers
{
    public class DependencyDemoController : Controller
    {

      private  readonly ICustomerService _weatherService;

      public DependencyDemoController(ICustomerService weatherService)
      {
        _weatherService = weatherService;
      }

      // GET: DependencyDemo
        public ActionResult Index()
        {
          var customers = _weatherService.GetTopCustomer(2);
            return View("Index");
        }
    }
}