using WebCrawler.API.Models;

namespace WebCrawler.API.Services.Interfaces
{
    public interface IProductsCrawlerService
    {
        public Task<List<Products>> GetSSD();
        public Task<List<Products>> GetRAM();
        public Task<List<Products>> GetMotherBoard();
        public Task<List<Products>> GetHD();
        public Task<List<Products>> GetGabinete();
    }
}
