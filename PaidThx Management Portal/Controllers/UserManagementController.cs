﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaidThx_Management_Portal.Models;

namespace PaidThx_Management_Portal.Controllers
{
    public class UserManagementController : Controller
    {
        //
        // GET: /UserManagement/

        public ActionResult Index()
        {
            return View("Index", new UserModels.IndexModel()
            {
                WebServicesBaseUrl = "http://23.21.203.171/api/internal"
            });
        }

        //
        // GET: /UserManagement/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /UserManagement/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserManagement/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /UserManagement/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UserManagement/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /UserManagement/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UserManagement/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
