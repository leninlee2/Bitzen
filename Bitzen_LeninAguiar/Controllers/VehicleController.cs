using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitzen_LeninAguiar.Models;
using Bitzen_LeninAguiar_Domain.Service;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bitzen_LeninAguiar.Controllers
{
    public class VehicleController : Controller
    {

        private VehicleService vehicleService;

        public VehicleController()
        {
            vehicleService = new VehicleService();
        }

        // GET: Vehicle
        public ActionResult Index()
        {
            VehicleViewModel viewModel = new VehicleViewModel();
            try {
                //get all vehicles by user
                
                int userid = (int)TempData["UserId"];
                var vehicles = vehicleService.FindByUser(userid);
                viewModel.vehicles = vehicles;
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
        public ActionResult Create()
        {
            VehicleViewModel viewModel = new VehicleViewModel();
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
                vehicle.userid = (int) TempData["UserId"];
                vehicle.year = viewModel.year;

                bool result = vehicleService.Create(vehicle);
                if (result)
                    viewModel.message = "Cadastro realizado com sucesso!";
                else
                    viewModel.message = "Problema ao salvar registro";

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