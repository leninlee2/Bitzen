using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitzen_LeninAguiar.Models;
using Bitzen_LeninAguiar_Domain.Interface;
using Bitzen_LeninAguiar_Domain.Service;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bitzen_LeninAguiar.Controllers
{
    public class VehicleController : Controller
    {

        private IVehicleService vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        // GET: Vehicle
        public ActionResult Index(int id)
        {
            VehicleViewModel viewModel = new VehicleViewModel();
            try {
                //get all vehicles by user
                int userid = 0;

                if (TempData["UserId"] != null)
                    userid = (int)TempData["UserId"];
                else
                    userid = id;

                var vehicles = vehicleService.FindByUser(userid);
                viewModel.vehicles = vehicles;
                TempData["UserId"] = userid;
            }
            catch(Exception ex) { 
            }
            return View(viewModel);
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehicle/Create
        public ActionResult Create(int id)
        {
            VehicleViewModel viewModel = new VehicleViewModel();
            TempData["UserId"] = id;
            viewModel.userid = id;
            return View(viewModel);
        }

        // POST: Vehicle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehicleViewModel viewModel)
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                vehicle.brand = viewModel.brand;
                vehicle.fueltype = viewModel.fueltype;
                vehicle.kilometers = viewModel.kilometers;
                vehicle.model = viewModel.model;
                vehicle.photopath = viewModel.photopath;
                vehicle.plaque = viewModel.plaque;
                if (TempData["UserId"] != null)
                    vehicle.userid = (int)TempData["UserId"];
                else
                {
                    vehicle.userid = viewModel.userid;
                    TempData["UserId"] = vehicle.userid;
                }
                    

                vehicle.year = viewModel.year;

                bool result = vehicleService.Create(vehicle);
                if (result)
                    viewModel.message = "Cadastro realizado com sucesso!";
                else
                    viewModel.message = "Problema ao salvar registro";

                viewModel.userid = vehicle.userid;

            }
            catch
            {
                
            }
            return View(viewModel);
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}