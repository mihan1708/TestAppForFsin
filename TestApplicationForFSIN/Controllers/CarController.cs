using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TestApplicationForFSIN.Models;
using TestApplicationForFSIN.ViewModels;

namespace TestApplicationForFSIN.Controllers
{
    public class CarController : Controller
    {
        ApplicationContext db;

        public CarController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<Car> cars = db.Cars.Include(c=>c.technical_Inspections).ToList();
            return View(cars);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if(car.Date_of_registration < car.Release)
            {
                ModelState.AddModelError("Date_of_registration", "дата постановки на учёт должна быть позже даты выпуска");
            }
            else if(db.Cars.FirstOrDefault(c => c.Registration_number == car.Registration_number) != null)
            {
                ModelState.AddModelError("Registration_number", "уже есть запись с таким уникальным рег. номером");
            }
            if(ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }
        public IActionResult Edit(int car_id)
        {
            Car car = db.Cars.Find(car_id);
            if(car!=null)
            {
                return View(car);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (car.Date_of_registration < car.Release)
            {
                ModelState.AddModelError("Date_of_registration", "дата постановки на учёт должна быть позже даты выпуска");
            }
            else if (db.Cars.FirstOrDefault(c => c.Registration_number == car.Registration_number) != null)
            {
                ModelState.AddModelError("Registration_number", "уже есть запись с таким уникальным рег. номером");
            }
            if (ModelState.IsValid)
            {
                Car _car = db.Cars.Find(car.Id);
                _car.Model = car.Model;
                _car.Registration_number = car.Registration_number;
                _car.Release = car.Release;
                _car.Date_of_registration = car.Date_of_registration;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }
        public IActionResult Delete(int car_id)
        {
            Car _car = db.Cars.Find(car_id);
            if(_car!=null)
            {
                db.Cars.Remove(_car);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Report()
        {
            ReportViewModel report = new ReportViewModel
            {
                count_Car = db.Cars.Count(),
                over_three_years_old = db.Cars.Where(c=>c.Release.AddYears(3)<DateTime.Now).Count(),
                more_than_three_years_old = db.Cars.Where(c=>c.Release.AddYears(3)>DateTime.Now).Count()
            };
            return View(report);
        }
    }
}

