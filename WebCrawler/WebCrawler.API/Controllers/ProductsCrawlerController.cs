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
        // GET
        [HttpGet]
        public async Task<IActionResult> GetAllAnotations(string product)
        {
            try
            {
                var data = new List<Products>();

                if (product == "SSD" || product == "ssd")
                    data = await _service.GetSSD();
                else if (product == "ram" || product == "RAM")
                    data = await _service.GetRAM();
                else if (product == "placa")
                    data = await _service.GetMotherBoard();
                else if (product == "hd" || product == "HD")
                    data = await _service.GetHD();

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
