﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPMS.WorkFlow.Core.Context;
using EPMS.WorkFlow.Core.Entities;
using EPMS.WorkFlow.Core.IRepository;
using EPMS.WorkFlow.Infrastructure.Dtos;
using EPMS.WorkFlow.Infrastructure.Repository;
using EPMS.WorkFlow.Web.ViewModels.Dashboard;

namespace EPMS.WorkFlow.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<MaintenanceRequest> maintenanceRequestRepository;
        private IExecStoreProcedure storeProcedure;

        public HomeController()
        {
            maintenanceRequestRepository = new Repository<MaintenanceRequest>(new WorkFlowContext());
            storeProcedure = new ExecStoreProcedure(new WorkFlowContext());
        }
        public ActionResult Index()
        {
            DashboardViewModel vm = new DashboardViewModel();
            var tilesInfo = storeProcedure.ExecTilesStoredProcedure<TileInfo>(1);
            var request = tilesInfo.Where(x => x.title == "Requests").FirstOrDefault();
            var worklist = tilesInfo.Where(x => x.title == "Worklists").FirstOrDefault();
            var assignment = tilesInfo.Where(x => x.title == "Assignments").FirstOrDefault();
            vm.WorklistChartInfo = storeProcedure.ExecWorklistStoredProcedure<WorklistChartInfo>(1);
            vm.Request = request;
            vm.Worklist = worklist;
            vm.Assignment = assignment;
            return View(vm);
        }

        public JsonResult CustomerList()
        {
            var sortingParms = Request.QueryString["columns"];
            var customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Shahid", Age = 23, Languages = "English,Pushto", Skills = "C#" });
            customers.Add(new Customer() { Name = "Imran", Age = 23, Languages = "English,URDU", Skills = "C#" });
            var pagesResult = new PagedList<Customer>(customers, 1, 10, 20);
            return Json(pagesResult, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public long Age { get; set; }
        public string Languages { get; set; }
        public string Skills { get; set; }
    }


    public class PagedList<T>
    {
        public IEnumerable<T> data { get; set; }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int recordsTotal { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 1 && TotalPages > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalRows)
        {
            recordsTotal = totalRows;
            TotalPages = totalRows / pageSize;
            if (totalRows % pageSize > 0)
                TotalPages++;
            PageSize = pageSize;
            PageIndex = pageIndex;
            data = source.ToList();
        }
    }
}