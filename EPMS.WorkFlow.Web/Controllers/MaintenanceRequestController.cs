using EPMS.WorkFlow.Core.Context;
using EPMS.WorkFlow.Core.Entities;
using EPMS.WorkFlow.Core.IRepository;
using EPMS.WorkFlow.Infrastructure.Constant;
using EPMS.WorkFlow.Infrastructure.Repository;
using EPMS.WorkFlow.Web.ViewModels.MaintenanceRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPMS.WorkFlow.Web.Controllers
{
    public class MaintenanceRequestController : Controller
    {
        private IRepository<MaintenanceRequest> maintenanceRequestRepository;

        public MaintenanceRequestController()
        {
            maintenanceRequestRepository = new Repository<MaintenanceRequest>(new WorkFlowContext());
        }
        // GET: MaintenanceRequest
        public ActionResult Index()
        {
            return View();
        }

        // GET: MaintenanceRequest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public JsonResult List()
        {
            var start = Request.QueryString["start"] != null ? Convert.ToInt32(Request.QueryString["start"]) : 1;
            var length = Request.QueryString["length"] != null ? Convert.ToInt32(Request.QueryString["length"]) : 10; 
            IList<MaintenanceRequest> requests = maintenanceRequestRepository.GetAll();

            var targetRequest = requests.Select(x => new MaintenanceListVM { Id = x.Id,Name = x.CustomerName, Email = x.Email, ContactNo = x.ContactNo, RequestBy = EPMS_Constants.RequestSource[x.RequestBy] != null ? EPMS_Constants.RequestSource[x.RequestBy] : null }).ToList();
            var pagesResult = new PagedList<MaintenanceListVM>(targetRequest, start, length, targetRequest.Count());
            return Json(pagesResult, JsonRequestBehavior.AllowGet);
        }

        // GET: MaintenanceRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaintenanceRequest/Create
        [HttpPost]
        public ActionResult Create(MaintenanceRequestVM vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }

                MaintenanceRequest maintenanceRequest = new MaintenanceRequest
                {
                    CustomerName = vm.CustomerName,
                    Email = vm.Email,
                    Adress = vm.Adress,
                    RequestReason = vm.RequestReason,
                    RequestBy = vm.RequestBy,
                    ContactNo = vm.ContactNo,
                    CreatedOn = DateTime.Now
                };
                maintenanceRequestRepository.Add(maintenanceRequest);
                maintenanceRequestRepository.Save();
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        // GET: MaintenanceRequest/Edit/5
        public ActionResult Edit(int id)
        {
            MaintenanceRequest model = maintenanceRequestRepository.Find(id);

            MaintenanceRequestVM vm = new MaintenanceRequestVM
            {
                CustomerName = model.CustomerName,
                Email = model.Email,
                Adress = model.Adress,
                RequestReason = model.RequestReason,
                RequestBy = model.RequestBy,
                ContactNo = model.ContactNo,
            };

            return View(vm);
        }

        // POST: MaintenanceRequest/Edit/5
        [HttpPost]
        public ActionResult Edit(MaintenanceRequest vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }

                MaintenanceRequest maintenanceRequest = new MaintenanceRequest
                {
                    Id = vm.Id,
                    CustomerName = vm.CustomerName,
                    Email = vm.Email,
                    Adress = vm.Adress,
                    RequestReason = vm.RequestReason,
                    RequestBy = vm.RequestBy,
                    ContactNo = vm.ContactNo,
                };
                maintenanceRequestRepository.Edit(maintenanceRequest);
                maintenanceRequestRepository.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // POST: MaintenanceRequest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                MaintenanceRequest model = maintenanceRequestRepository.Find(id);
                maintenanceRequestRepository.Remove(model);
                maintenanceRequestRepository.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
