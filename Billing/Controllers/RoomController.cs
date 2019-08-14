using Billing.Models;
using LNF.Models;
using LNF.Models.Billing;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Billing.Controllers
{
    public class RoomController : Controller
    {
        protected IProvider Provider { get; }

        public RoomController(IProvider provider)
        {
            Provider = provider;
        }

        [HttpGet, Route("room/import-log")]
        public ActionResult ImportLog()
        {
            var model = new ImportLogModel
            {
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1)
            };

            return View(model);
        }

        [HttpPost, Route("room/import-log")]
        public ActionResult ImportLog(ImportLogModel model)
        {
            model.Items = Provider.Billing.Room.GetImportLogs(model.StartDate, model.EndDate);
            return View(model);
        }
    }
}