using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIShowcase.Interfaces;
using DIShowcase.Services;
using Microsoft.AspNet.Mvc;

namespace DIShowcase.Controllers
{
    public class HomeController : Controller
    {

        private ISampleRequest sampleRequest { get; set; }
        private ISampleService sampleService { get; set; }
        private SampleWithoutInterface sampleWithoutInterface { get; set; }

        private SampleTransient sampleTransient { get; set; }


        public HomeController(ISampleRequest sampleRequest, ISampleService sampleService, SampleWithoutInterface sampleWithoutInterface, SampleTransient sampleTransient)
        {
            this.sampleRequest = sampleRequest;

            this.sampleService = sampleService;

            this.sampleWithoutInterface = sampleWithoutInterface;

            this.sampleTransient = sampleTransient;
        }

        public IActionResult Index()
        {
            var requestService = HttpContext.RequestServices.GetService(typeof(ISampleRequest)); // per request

            var applicationService = (SampleSingleton)HttpContext.ApplicationServices.GetService(typeof (ISampleSingleton));


            ViewData["sampleRequest"] = sampleRequest.HelloRequest();
            ViewData["sampleService"] = sampleService.HelloWorld();

            ViewData["sampleTransient.request"] = sampleTransient.sampleRequest.HelloRequest();
            ViewData["sampleTransient.service"] = sampleTransient.sampleService.HelloWorld();

            ViewData["sampleSingleton"] = applicationService.HelloSingleton();
            ViewData["sampleWithoutInterface"] = sampleWithoutInterface.Test();

            return View();

        }
    }
}
