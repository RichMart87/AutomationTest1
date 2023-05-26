using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace AutomationTest
{
    public class WebDriverConfig : IDisposable
    {
          //Creating reference for Browser
        public ChromeDriver ChromeDriver { get; private set; }
        public WebDriverConfig()
        {
            //WebDriverManager
            var driver = new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            
        }
        public void Dispose() //cleanup
            {
                ChromeDriver.Quit();
                ChromeDriver.Dispose();
            }

        }
    }
    

