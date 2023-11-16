﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalRLiveSportsDashboardDemo.Data;
using SignalRLiveSportsDashboardDemo.Models;
using SignalRLiveSportsDashboardDemo.Services;

namespace SignalRLiveSportsDashboardDemo.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 
    }
}
