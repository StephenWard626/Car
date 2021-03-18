using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            Vehicle myCar = new Vehicle() { Make = "Toyota", Model = "Yaris", Engine = EngineType.Hybrid, EngineSize = 20 };
            return View(myCar);


        }
    }
}
