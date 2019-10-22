using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace First.NetProject.Controllers
{
    public class FriendsInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}