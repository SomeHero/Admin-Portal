using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaidThx_Management_Portal.Models;

namespace PaidThx_Management_Portal.Controllers
{
    public class MessagesController : Controller
    {
        //
        // GET: /Messages/

        public ActionResult Index()
        {
            return View("Index", new MessageModels.IndexModel()
            {
                WebServicesBaseUrl = "http://23.21.203.171/api/internal"
            });
        }

        //
        // GET: /Messages/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Messages/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Messages/Create

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
        // GET: /Messages/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Messages/Edit/5

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
        // GET: /Messages/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Messages/Delete/5

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
