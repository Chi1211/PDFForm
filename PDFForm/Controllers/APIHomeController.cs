using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDFForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFForm.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIHomeController : ControllerBase
    {
        //[HttpGet]
        //public List<Pizza> Order()
        //{
        //    List<Pizza> pz = new List<Pizza>();
        //    return pz;
        //}

        [HttpPost]
        public IActionResult Order(Pizza pizza)
        {
            return Ok();
        }
    }
}
