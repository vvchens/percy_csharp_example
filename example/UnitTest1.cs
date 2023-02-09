using OpenQA.Selenium.Chrome;
using percy_csharp_selenium;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var driver = new ChromeDriver();
            var percy = new Percy();

            driver.Url = "https://google.com";

            percy.Snapshot(driver, "Docs Page", new Dictionary<string, object> {
                {"widths", new List<int> { 768, 992, 1200 }},
                { "minHeight", 1200 },
                { "enableJavaScript",  false },
                { "percyCSS", ".clear-completed { visibility: hidden; }" }
                });

            driver.Quit();
        }
    }
}