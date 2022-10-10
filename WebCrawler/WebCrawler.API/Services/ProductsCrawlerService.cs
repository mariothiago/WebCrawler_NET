using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data.Common;
using System.Data;
using WebCrawler.API.Models;
using WebCrawler.API.Services.Interfaces;

namespace WebCrawler.API.Services
{
    public class ProductsCrawlerService : IProductsCrawlerService
    {
        public async Task<List<Products>> GetGabinete()
        {
            try
            {
                var product = new Products();
                var productList = new List<Products>();

                IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.CssSelector(".dZlrn"));

                foreach (var item in items)
                {
                    product.Price = item.Text;
                    Console.WriteLine(product.Price);
                    productList.Add(product);
                }

                driver.Close();
                return productList;
            }
            catch(Exception ex)
            {
                throw new Exception($"Exception {ex.Message} at: {ex.StackTrace}");
            }
        }

        public async Task<List<Products>> GetHD()
        {
            
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                foreach (var tag in tags)
                {
                    var product = new Products();
                    var textSplit = tag.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    product.Description = textSplit[0];
                    product.Price = textSplit[2];
                    product.Company = "Kabum";

                    productList.Add(product);
                }
                driver.Close();

                return productList;
            }
            catch(Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
            
        }


        public async Task<List<Products>> GetMotherBoard()
        {
            try
            {
                var product = new Products();
                var productList = new List<Products>();

                IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.CssSelector(".dZlrn"));

                foreach (var item in items)
                {
                    product.Price = item.Text;
                    Console.WriteLine(product.Price);
                    productList.Add(product);
                }
                driver.Close();

                return productList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception {ex.Message} at: {ex.StackTrace}");
            }
        }

        public async Task<List<Products>> GetRAM()
        {
            try
            {
                var product = new Products();
                var productList = new List<Products>();

                IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.CssSelector(".dZlrn"));

                foreach (var item in items)
                {
                    product.Price = item.Text;
                    Console.WriteLine(product.Price);
                    productList.Add(product);
                }

                return productList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception {ex.Message} at: {ex.StackTrace}");
            }
        }

        public async Task<List<Products>> GetSSD()
        {
            try
            {
                var product = new Products();
                var productList = new List<Products>();

                IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.CssSelector(".dZlrn"));

                foreach (var item in items)
                {
                    product.Price = item.Text;
                    Console.WriteLine(product.Price);
                    productList.Add(product);
                }

                return productList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception {ex.Message} at: {ex.StackTrace}");
            }
        }
    }
}
