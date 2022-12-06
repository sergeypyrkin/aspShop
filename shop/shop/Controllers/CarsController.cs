using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;



        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat)
        {
            _allCars = iallCars;
            _allCategory = iCarsCat;
        }

        public ViewResult List()
        {

            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Some New";
            //ViewBag.Category = "Some New";
            //var cars = _allCars.Cars;
            //return View(cars);
            return View(obj);
        }

    }
}
