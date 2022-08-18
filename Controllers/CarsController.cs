﻿using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "Cars";

            return View(obj);
        }
    }
}
