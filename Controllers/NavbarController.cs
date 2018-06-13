using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SisCor.Domain;
using Microsoft.AspNetCore.Authorization;

namespace SisCor.Controllers
{
    [Authorize]
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Index()
        {
            return PartialView("_Navbar", new Data().navbarItems().ToList());
        }
    }
}