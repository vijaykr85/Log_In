using Log_In.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Log_In.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext productContext;

        public HomeController(ProductContext productContext)
        {
            this.productContext = productContext;
        }

        public IActionResult Index()
        {
            return View();
        }
      

        public IActionResult GetData1()
        {
            try
            {
                var data = productContext.productDetails.ToList();
                return Json(data);

            }
            catch (Exception ex)
            {
                return View();
            }

        }

        public IActionResult Create(Product pp,IFormFile Image)
        {
            using MemoryStream Stream = new MemoryStream();
            if(Image != null)
            {
                Image.CopyTo(Stream);
                pp.image = Stream.ToArray();

                productContext.productDetails.Add(pp);
                productContext.SaveChanges();
            }





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
    }

    public class productContext
    {
    }
}


