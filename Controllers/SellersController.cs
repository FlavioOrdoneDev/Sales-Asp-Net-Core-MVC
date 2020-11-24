using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales_ASPNET_Core.Services;

namespace Sales_ASPNET_Core.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _service;

        public SellersController(SellerService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.FindAll());
        }
    }
}
