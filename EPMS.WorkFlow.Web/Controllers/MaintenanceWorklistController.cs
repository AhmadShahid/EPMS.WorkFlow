using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPMS.WorkFlow.Core.Context;
using EPMS.WorkFlow.Core.Entities;
using EPMS.WorkFlow.Core.IRepository;
using EPMS.WorkFlow.Infrastructure.Constant;
using EPMS.WorkFlow.Infrastructure.Repository;
using EPMS.WorkFlow.Web.ViewModels.MaintenanceWorklist;

namespace EPMS.WorkFlow.Web.Controllers
{
    public class MaintenanceWorklistController : Controller
    {
        private IRepository<MaintenanceWorklist> maintenanceWorklistRepository;

        public MaintenanceWorklistController()
        {
            maintenanceWorklistRepository = new Repository<MaintenanceWorklist>(new WorkFlowContext());
        }
        // GET: MaintenanceWorklist
        public ActionResult Index()
        {
           
            return View();
        }

        public JsonResult List()
        {
            var start = Request.QueryString["start"] != null ? Convert.ToInt32(Request.QueryString["start"]) : 1;
            var length = Request.QueryString["length"] != null ? Convert.ToInt32(Request.QueryString["length"]) : 10;
            IList<MaintenanceWorklist> requests = maintenanceWorklistRepository.GetAll();

            var targetWorklist = requests.Select(x => new MaintenanceWorklistListViewModel { Id = x.Id, Name = "Test.00.1",Status = EPMS_Constants.WorklistStatus[x.Status] != null ? EPMS_Constants.WorklistStatus[x.Status] : null,ExpiryDate= x.ExpirationDate.HasValue ? x.ExpirationDate.Value.ToString("yyyy-MM-dd") : null, IsCompleted= x.IsCompleted ? "Yes" : "No" }).ToList();
            var pagesResult = new PagedList<MaintenanceWorklistListViewModel>(targetWorklist, start, length, targetWorklist.Count());
            return Json(pagesResult, JsonRequestBehavior.AllowGet);
        }
        // GET: MaintenanceWorklist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaintenanceWorklist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaintenanceWorklist/Create
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

        // GET: MaintenanceWorklist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaintenanceWorklist/Edit/5
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

        // GET: MaintenanceWorklist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaintenanceWorklist/Delete/5
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
