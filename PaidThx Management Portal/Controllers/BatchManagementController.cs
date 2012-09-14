using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using System.IO;
using System.Configuration;
using PaidThx_Management_Portal.Models;

namespace PaidThx_Management_Portal.Controllers
{
    public class BatchManagementController : Controller
    {
        //
        // GET: /BatchManagement/
        [Authorize]
        public ActionResult Index()
        {
            var internalAPIUrl = ConfigurationManager.AppSettings["webServicesBaseUrl"];

            var betaSignUpUrl = internalAPIUrl + "/api/Batches/current?apiKey=BDA11D91-7ADE-4DA1-855D-24ADFE39D174";
            JavaScriptSerializer js = new JavaScriptSerializer();

            // Create new HTTP request.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(betaSignUpUrl);
            req.Method = "GET";
            //req.ContentType = "application/json";
            //byte[] postData = Encoding.ASCII.GetBytes(json);
            //req.ContentLength = postData.Length;

            // Send HTTP request.
            //Stream PostStream = req.GetRequestStream();
           // PostStream.Write(postData, 0, postData.Length);
            HttpStatusCode statusCode = HttpStatusCode.OK;
            HttpWebResponse httpResponse = null;

            string statusReason = "";
            try
            {
                httpResponse = (HttpWebResponse)req.GetResponse();

                statusCode = httpResponse.StatusCode;
                statusReason = httpResponse.StatusDescription;

            }
            catch (WebException ex)
            {
                using (WebResponse response = ex.Response)
                {
                    httpResponse = (HttpWebResponse)response;

                    statusCode = httpResponse.StatusCode;
                    statusReason = httpResponse.StatusDescription;

                }
            }

            if (statusCode.Equals(HttpStatusCode.OK))
            {
                BatchModels.BatchResponseModel myObj = null;

                using (var reader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var obj = reader.ReadToEnd();

                    myObj = (BatchModels.BatchResponseModel)js.Deserialize(obj, typeof(BatchModels.BatchResponseModel));
                }

                return View("Index", new BatchModels.IndexModel()
                {
                    WebServicesBaseUrl = "http://23.21.203.171/api/internal",
                    BatchClosed = null,
                    BatchId = myObj.Id,
                    BatchOpened = System.DateTime.Now.AddHours(-2),
                    BatchSent = null,
                    BatchStatus = "Batch Open",
                    BatchVerified = null,
                    TotalDepositAmount = myObj.TotalDepositAmount,
                    TotalNumberOfDeposits = myObj.TotalNumberOfDeposits,
                    TotalNumberOfWithdrawals = myObj.TotalNumberOfWithdrawals,
                    TotalWithdrawalAmount = myObj.TotalWithdrawalAmount,
                    TotalNumberOfTransactions = myObj.TotalNumberOfDeposits + myObj.TotalNumberOfWithdrawals,
                    TotalTransactionAmount = myObj.TotalDepositAmount + myObj.TotalWithdrawalAmount
                });
            }
            else
            {
                return View("Index");
            }
        }

        //
        // GET: /BatchManagement/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BatchManagement/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BatchManagement/Create

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
        // GET: /BatchManagement/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BatchManagement/Edit/5

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
        // GET: /BatchManagement/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BatchManagement/Delete/5

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
