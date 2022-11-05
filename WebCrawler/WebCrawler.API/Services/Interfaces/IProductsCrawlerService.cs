using WebCrawler.API.Models;

namespace WebCrawler.API.Services.Interfaces
{
    public interface IProductsCrawlerService
    {
        public List<Products> GetSSD();
        public List<Products> GetRAM();
        public List<Products> GetMotherBoard();
        public List<Products> GetHD();
        public List<Products> GetHeadset();
        public List<Products> GetGabinete();
    }
}
