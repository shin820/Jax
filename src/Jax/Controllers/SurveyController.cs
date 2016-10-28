using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jax.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jax.Controllers
{
    public class SurveyController : Controller
    {
        public List<Survey> Index()
        {
            return new List<Survey>()
            {
                new Survey {Id = 0, Name = "test"}
            };
        }

        [Route("Survey/Index/{id}")]
        public Survey Index(int id)
        {
            return new Survey { Id = 0, Name = "test" };
        }
    }
}
