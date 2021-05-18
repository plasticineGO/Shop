using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_1.Data.interfaces;
using WebApplication_1.ViewModels;

namespace WebApplication_1.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRep;


        public HomeController(IAllCars iAllCars)
        {
            _carRep = iAllCars;


        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel { favCars = _carRep.getFavCars };
            return View(homeCars);
        }


    }
}