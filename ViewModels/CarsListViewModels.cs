using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_1.Data.Models;

namespace WebApplication_1.ViewModels
{
    public class CarsListViewModels
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}