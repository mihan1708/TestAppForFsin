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
        public IActionResult getInspections(int car_id)
        {
            Car car = db.Cars.Include(i => i.technical_Inspections).FirstOrDefault(i=>i.Id == car_id);
            
            return View(car);
        }
        public IActionResult Create(int car_id)
        {
            Car car = db.Cars.Find(car_id);
            if (car != null)
            {
                CreateInspectionViewModel inspViewModel = new CreateInspectionViewModel
                {
                    Car = car
                };
                return View(inspViewModel);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(CreateInspectionViewModel inspViewModel)
        {
            if(inspViewModel.Date_inspection < inspViewModel.Car.Release)
            {
                ModelState.AddModelError("Date_inspection", "дата осмотра должна быть позже даты выпуска автомобиля");
            }
            else if(db.Inspections.FirstOrDefault(i => i.Number == inspViewModel.Number) != null)
            {
                ModelState.AddModelError("Number", "такой номер карты уже записан");
            }
            if(ModelState.IsValid)
            {
                Technical_inspection inspection = new Technical_inspection
                {
                    Car = db.Cars.Find(inspViewModel.Car.Id),
                    Date_inspection = inspViewModel.Date_inspection,
                    Number = inspViewModel.Number,
                    Remarks = inspViewModel.Remarks,

                };
                db.Inspections.Add(inspection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inspViewModel);
        }
        public IActionResult Edit(int insp_id)
        {
            Technical_inspection inspection = db.Inspections.Include(i => i.Car).FirstOrDefault(i => i.Id == insp_id);
            if (inspection == null)
            {
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
            if(inspViewModel.Date_inspection < _insp.Car.Release)
            {
                ModelState.AddModelError("Date_inspection", "дата осмотра должна быть позже даты выпуска автомобиля");
            }
            else if(db.Inspections.FirstOrDefault(i => i.Number == inspViewModel.Number && i.Id != inspViewModel.Id) != null)
            {
                ModelState.AddModelError("Number", "такой номер карты уже записан");
            }
            if(ModelState.IsValid)
            {
                _insp.Number = inspViewModel.Number;
                _insp.Date_inspection = inspViewModel.Date_inspection;
                _insp.Remarks = inspViewModel.Remarks;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(inspViewModel);
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
