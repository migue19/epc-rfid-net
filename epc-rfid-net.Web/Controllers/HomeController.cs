using epc_rfid_net.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace epc_rfid_net.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Connect(string readerIp)
        {
            // Validar y procesar la IP ingresada
            if (string.IsNullOrEmpty(readerIp))
            {
                // Manejar el caso cuando la IP está vacía o es nula
                ModelState.AddModelError("ReaderIp", "La IP no puede estar vacía.");
                return View("Index");
            }

            // Crear una instancia del modelo de vista con la IP procesada
            var model = new ConnectedViewModel { ReaderIp = readerIp };

            // Pasar el modelo de vista a la siguiente vista
            return View("Connected", model);
        }
    }
}
