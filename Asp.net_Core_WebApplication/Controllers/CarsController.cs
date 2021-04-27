using Asp.net_Core_WebApplication.Data.interfaces;
using Asp.net_Core_WebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_WebApplication.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategory = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with auto";
            CarsListViewModel obj = new CarsListViewModel
            {
                allCars = _allCars.Cars,
                currentCategory = "Auto"
            };
            return View(obj);
        }
    }
}
