using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDFForm.Models;
using System;
//using System.Web.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using TallComponents.PDF;
using TallComponents.PDF.Forms.Data;
using TallComponents.PDF.Forms.Fields;
using TallComponents.PDF.Annotations.Widgets;
using System.Diagnostics;
using TallComponents.PDF.Shapes;
using TallComponents.PDF.Fonts;
using iTextSharp.text.pdf;
using Xunit.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace PDFForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        // private readonly ITestOutputHelper _output;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            // _output = output;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {

            return File("~/pdf"+"/5"+"/order-pizza.pdf", "application/pdf"); 
        }

        [HttpPost]
        public IActionResult Order(IFormFile file)
        {
            //using (FileStream inputStream = new FileStream(path: @"wwwroot\pdf\order-pizza.pdf", mode: FileMode.Open))
            //{
            //    using (Stream outStream = new MemoryStream())
            //    {
            //        PdfReader pdfReader = null;
            //        PdfStamper pdfStamper = null;
            //        Stream inStream = null;
            //        try
            //        {
            //            pdfReader = new PdfReader(inputStream);
            //            using (pdfStamper = new PdfStamper(pdfReader, outStream))
            //            {
            //                AcroFields form = pdfStamper.AcroFields;
            //                form.SetField("Size", pizza.Size);
            //                form.SetField("Tomatoes", pizza.Tomatoes);
            //                form.SetField("Onions", pizza.Onions);
            //                form.SetField("Tuna", pizza.Tuna);
            //                form.SetField("Cheese", pizza.Cheese);
            //                form.SetField("Name", pizza.Name);
            //                //set this if you want the result PDF to be uneditable. 
            //                pdfStamper.FormFlattening = true;
            //            };

            //        }
            //        finally
            //        {
            //            pdfStamper.Close();
            //            pdfReader.Close();
            //            inStream.Close();
            //        }
            //        return View(outStream);
            //    };


            //};
            //return View();
            return File("~/pdf/5/order-pizza.pdf", "application/pdf");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
