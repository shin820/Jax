using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jax.Controllers
{
    public class SurveyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            JaxContext context = new JaxContext();
            return View(await context.Survey.ToListAsync());
        }
    }
}
