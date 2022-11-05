using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebCrawler.API.Models;
using WebCrawler.API.Services.Interfaces;

namespace WebCrawler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCrawlerController : Controller
    {
        private IProductsCrawlerService _service { get; set; }

        public ProductsCrawlerController(IProductsCrawlerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllAnotations(string product)
        {
            try
            {
                var data = new List<Products>();

                if (product == "SSD" || product == "ssd")
                    data = _service.GetSSD();
                else if (product == "ram" || product == "RAM")
                    data = _service.GetRAM();
                else if (product == "placa")
                    data = _service.GetMotherBoard();
                else if (product == "hd" || product == "HD")
                    data = _service.GetHD();
                else if(product == "headset" || product == "Headset")
                    data = _service.GetHeadset();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
