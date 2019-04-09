using Billing.Models;
using System.Web.Mvc;

namespace Billing.Controllers
{
    public class RoomController : Controller
    {
        [Route("room/import-log")]
        public ActionResult ImportLog()
        {
            return View();
        }

        [Route("room/import-log")]
        public ActionResult ImportLog(ImportLogModel model)
        {
            return View(model);
        }
    }
}