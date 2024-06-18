using epc_rfid_net.Model;
using epc_rfid_net.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace epc_rfid_net.Web.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ILogger<InventoriesController> _logger;

        public InventoriesController(ILogger<InventoriesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = new List<Inventory>();
            return View(list);
        }


    }
}
