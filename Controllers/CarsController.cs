using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_1.Data.interfaces;
using WebApplication_1.Data.Models;
using WebApplication_1.ViewModels;

namespace WebApplication_1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/{List?}")]
        [Route("Cars/List/{category?}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(_category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(c => c.Category.categoryName == "Электромобили").OrderBy(id => id.id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(c => c.Category.categoryName == "Классические автомобили").OrderBy(id => id.id);
                    currCategory = "Классические автомобили";
                }

            }


            ViewBag.Title = "страничка с автомобилями";
            CarsListViewModels obj = new CarsListViewModels()
            {
                allCars = cars,
                currCategory = currCategory
            };
            return View(obj);

            //obj.currCategory = "Автомобили";
            //return View(obj); 
        }
    }
}
