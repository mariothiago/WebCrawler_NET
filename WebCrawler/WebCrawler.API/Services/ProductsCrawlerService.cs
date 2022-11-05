using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebCrawler.API.Models;
using WebCrawler.API.Services.Interfaces;

namespace WebCrawler.API.Services
{
    public class ProductsCrawlerService : IProductsCrawlerService
    {
        public List<Products> GetGabinete()
        {
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                driver.Url = "https://www.kabum.com.br/perifericos/gabinetes";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                foreach (var tag in tags!)
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
            catch (Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
        }



        public List<Products> GetHD()
        {
            
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                driver.Url = "https://www.kabum.com.br/hardware/disco-rigido-hd";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                foreach (var tag in tags!)
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

        public List<Products> GetHeadset()
        {
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                #region Kabum
                driver.Url = "https://www.kabum.com.br/perifericos/headset-gamer";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                if (tags!.Any())
                {
                    foreach (var tag in tags!)
                    {
                        var product = new Products();
                        var textSplit = tag.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        product.Description = textSplit[0];
                        product.Price = textSplit[2];
                        product.Company = "Kabum";

                        productList.Add(product);
                    }

                    driver.Close();
                }
                #endregion

                #region ecommerce 1

                #endregion 

                return productList;
            }
            catch (Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
        }

        public List<Products> GetMotherBoard()
        {
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                #region Kabum
                driver.Url = "https://www.kabum.com.br/hardware/placas-mae";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                if (tags!.Any())
                {
                    foreach (var tag in tags!)
                    {
                        var product = new Products();
                        var textSplit = tag.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        product.Description = textSplit[0];
                        product.Price = textSplit[2];
                        product.Company = "Kabum";

                        productList.Add(product);
                    }

                    driver.Close();
                }
                #endregion

                #region ecommerce 1

                #endregion 

                return productList;
            }
            catch (Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
        }

        public List<Products> GetRAM()
        {
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                #region Kabum
                driver.Url = "https://www.kabum.com.br/hardware/memoria-ram";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                if (tags!.Any())
                {
                    foreach (var tag in tags!)
                    {
                        var product = new Products();
                        var textSplit = tag.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        product.Description = textSplit[0];
                        product.Price = textSplit[2];
                        product.Company = "Kabum";

                        productList.Add(product);
                    }

                    driver.Close();
                }
                #endregion

                #region ecommerce 1

                #endregion 

                return productList;
            }
            catch (Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
        }

        public List<Products> GetSSD()
        {
            var productList = new List<Products>();

            IWebDriver driver = new ChromeDriver($@"F:\Users\Thiago\Downloads\Programs\");

            try
            {
                #region Kabum
                driver.Url = "https://www.kabum.com.br/hardware/ssd-2-5";
                var items = driver.FindElements(By.TagName("main"));
                var tags = items.FirstOrDefault(x => x.TagName == "main")?.FindElements(By.TagName("a"));
                if (tags!.Any())
                {
                    foreach (var tag in tags!)
                    {
                        var product = new Products();
                        var textSplit = tag.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        product.Description = textSplit[0];
                        product.Price = textSplit[2];
                        product.Company = "Kabum";

                        productList.Add(product);
                    }

                    driver.Close();
                }
                #endregion

                #region ecommerce 1

                #endregion 

                return productList;
            }
            catch (Exception ex)
            {
                driver.Close();
                throw new Exception($"Error: {ex.Message} at: {ex.StackTrace}");
            }
        }
    }
}
