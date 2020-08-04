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
    public class LoginController : Controller
    {
        ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        public ActionResult Index(LoginViewModel viewModel)
        {
            Login result = new Login();
            viewModel.authenticated = false;
            try
            {
                result = loginService.Authentication(viewModel.login, viewModel.password);

                if (result.id > 0)
                {
                    viewModel.authenticated = true;
                    TempData["UserId"] = result.id;
                    //Microsoft.AspNetCore.Session.DistributedSession["UserId"] = result.id;//.SetInt32("UserId", result.id);
                }
                else
                    viewModel.message = "Login ou senhas inválidos";
            }
            catch(Exception ex)
            {
                viewModel.message = ex.Message;
            }
            
            return View(viewModel);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            LoginViewModel viewModel = new LoginViewModel();
            return View(viewModel);
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(LoginViewModel viewModel)
        {
            try { 
                if(!String.IsNullOrEmpty(viewModel.login) 
                    && !String.IsNullOrEmpty(viewModel.password)
                    && !String.IsNullOrEmpty(viewModel.name)
                    )
                {
                    Login login = new Login();
                    login.email = viewModel.login;
                    login.name = viewModel.name;
                    login.password = viewModel.password;
                    login = loginService.Create(login);
                    if (login.id > 0)
                        viewModel.message = "Usuário cadastrado com sucesso!";
                }
            }
            catch(Exception ex) { 
            
            }
            return View(viewModel);
        }


        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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