﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
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
        public ViewResult List()
        {
            ViewBag.Category = "Some New";
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
