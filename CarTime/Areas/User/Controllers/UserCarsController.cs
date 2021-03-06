﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarTime.Domain;
using CarTime.Domain.Entities;
using CarTime.Service;

namespace CarTime.Areas.User.Controllers
{
    [Area("User")]
    public class UserCarsController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly ShopCart _shopCart;

        public UserCarsController(DataManager dataManager, ShopCart shopCart)
        {
            _dataManager = dataManager;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            List<CarItem> Cars = _dataManager.CarItems.GetAvailableCars();
            return View(Cars);
        }

        public IActionResult CarDetails(Guid carId)
        {
            CarItem car = _dataManager.CarItems.GetCarById(carId);
            return View(car);
        }

        public IActionResult ToCart(Guid carId)
        {
            var item = _dataManager.CarItems.GetCarById(carId);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index", "UserShopCart");
        }
    }
}