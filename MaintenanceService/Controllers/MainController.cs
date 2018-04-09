using MaintenanceService.Lib.Models;
using MaintenanceService.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintenanceService.Controllers
{
    public class MainController : Controller
    {
        /// <summary>
        /// Maintenance page
        /// </summary>
        public ActionResult Index(int clientId)
        {
            ContentViewModel viewModel = new ContentViewModel();

            return View();
        }                                          
    }
}
