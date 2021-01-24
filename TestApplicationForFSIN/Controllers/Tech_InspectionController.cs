using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplicationForFSIN.Models;
using Microsoft.EntityFrameworkCore;
using TestApplicationForFSIN.ViewModels;

namespace TestApplicationForFSIN.Controllers
{
    public class Tech_InspectionController : Controller
    {
        ApplicationContext db;
        public Tech_InspectionController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<Technical_inspection> inspections = db.Inspections.Include(i=>i.Car).ToList();
            return View(inspections);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateInspectionViewModel inspViewModel)
        {
            if (inspViewModel == null)
            {
                ViewBag.error = "заполните поля";
                return View();
            }
            Car _car = db.Cars.Find(inspViewModel.Car_Id);
            if (_car == null)
            {
                ViewBag.error = "не найдена запись с таким идентификатором";
                return View();
            }
            if (inspViewModel.Date_inspection < _car.Release)
            {
                ViewBag.error = "дата осмотра должна быть позже даты выпуска автомобиля";
                return View();
            }
            if (db.Inspections.FirstOrDefault(i => i.Number == inspViewModel.Number) != null)
            {
                ViewBag.error = "уже есть запись с таким уникальным номером карты тех.осмотра";
                return View();
            }
            Technical_inspection inspection = new Technical_inspection
            {
                Car = _car,
                Date_inspection = inspViewModel.Date_inspection,
                Number = inspViewModel.Number,
                Remarks = inspViewModel.Remarks

            };
            db.Inspections.Add(inspection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int insp_id)
        {
            Technical_inspection inspection = db.Inspections.Include(i => i.Car).FirstOrDefault(i => i.Id == insp_id);
            if (inspection == null)
            {
                ViewBag.error = "не найдена запись с таким идентификатором";
                return View();
            }
            EditInspectionViewModel viewModel = new EditInspectionViewModel
            {
                Id = insp_id,
                Car_Id = inspection.Car.Id,
                Date_inspection = inspection.Date_inspection,
                Number = inspection.Number,
                Remarks = inspection.Remarks
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditInspectionViewModel inspViewModel)
        {
            Technical_inspection _insp = db.Inspections.Include(i => i.Car).FirstOrDefault(i => i.Id == inspViewModel.Id);
            if (inspViewModel == null)
            {
                ViewBag.error = "заполните поля";
                return View();
            }
            Car _car = db.Cars.Find(inspViewModel.Car_Id);
            if (_car == null)
            {
                ViewBag.error = "не найдена запись с таким идентификатором";
                return View();
            }
            if (inspViewModel.Date_inspection < _car.Release)
            {
                ViewBag.error = "дата осмотра должна быть позже даты выпуска автомобиля";
                return View(inspViewModel);
            }
            if (_insp == null)
            {
                ViewBag.error = "не найдена запись с таким идентификатором";
                return View();
            }
            if(db.Inspections.FirstOrDefault(i=>i.Number==inspViewModel.Number && i.Id!=inspViewModel.Id)!=null)
            {
                ViewBag.error = "уже есть запись с таким уникальным номером карты";
                //return View();
                return RedirectToAction("Edit", new { insp_id = inspViewModel.Id});
            }
            _insp.Number = inspViewModel.Number;
            _insp.Date_inspection = inspViewModel.Date_inspection;
            _insp.Remarks = inspViewModel.Remarks;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int insp_id)
        {
            Technical_inspection _insp = db.Inspections.Find(insp_id);
            if (_insp != null)
            {
                db.Inspections.Remove(_insp);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
