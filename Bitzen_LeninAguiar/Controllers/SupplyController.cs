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
    public class SupplyController : Controller
    {
        private ISupplyService supplyService;
        private IVehicleService vehicleService;

        public SupplyController(ISupplyService supplyService, IVehicleService vehicleService)
        {
            this.supplyService = supplyService;
            this.vehicleService = vehicleService;
        }

        // GET: Supply
        public ActionResult Index(int id)
        {
            SupplyViewModel viewModel = new SupplyViewModel();
            try {
                int userid = 0;

                if (TempData["UserId"] != null)
                    userid = (int)TempData["UserId"];
                else
                    userid = id;


                TempData["UserId"] = userid;
                viewModel.userid = userid;
                viewModel.supplies = supplyService.FindByUserId(userid);
            }
            catch(Exception ex)
            {

            }
            return View(viewModel);
        }

        // GET: Supply/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supply/Create
        public ActionResult Create(int id)
        {
            SupplyViewModel viewModel = new SupplyViewModel();

            try {
                int userid = 0;
                if (TempData["UserId"] != null)
                    userid = (int)TempData["UserId"];
                else
                {
                    userid = id;
                    TempData["UserId"] = userid;
                }
                    
                var vehicles =  vehicleService.FindByUser(userid);
                viewModel.vehicles = vehicles;
                viewModel.userid = userid;
            }
            catch(Exception ex)
            {

            }
            return View(viewModel);
        }

        // POST: Supply/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SupplyViewModel viewModel)
        {
            try
            {
                Supply supply = new Supply();
                int userid = 0;

                if (TempData["UserId"] != null)
                    userid = (int)TempData["UserId"];
                else
                {
                    userid = viewModel.userid;
                    TempData["UserId"] = userid;
                }
                    

                supply.datasupply = viewModel.datasupply;
                supply.fueltype = viewModel.fueltype;
                supply.kmsupply = viewModel.kmsupply;
                supply.quantity = viewModel.quantity;
                supply.userid = userid;
                supply.value = viewModel.value;
                supply.vehicleid = viewModel.vehicleid;
                supply.companyname = viewModel.companyname;

                bool result = supplyService.Create(supply);
                var vehicles = vehicleService.FindByUser(userid);
                viewModel.vehicles = vehicles;

                if (result)
                    viewModel.message = "Cadastro Realizado com sucesso!";
                else
                    viewModel.message = "Falha no cadastro de abastecimento";


            }
            catch
            {
                
            }
            return View(viewModel);
        }

        // GET: Supply/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Supply/Edit/5
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

        // GET: Supply/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Supply/Delete/5
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