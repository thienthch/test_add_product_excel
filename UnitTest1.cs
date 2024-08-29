using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestCaseLaptop
{
    public class XemchitietspTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }


        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


        public string waitForWindow(int timeout)
        {
            try
            {
                Thread.Sleep(timeout);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
            var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
            if (whNow.Count > whThen.Count)
            {
                return whNow.Except(whThen).First().ToString();
            }
            else
            {
                return whNow.First().ToString();
            }
        }


        [Test]
        public void xemchitietsp()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_181 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_181 > td:nth-child(2)")).Text, Is.EqualTo("Laptop MSI Gaming GP76 11UG i7 11800H/ 16GB/ 1TB SSD/ 8GB RTX3070/ 240Hz/ Balo/ Chuột/ Win10 (435VN)"));
            driver.FindElement(By.CssSelector("#item_181 > td:nth-child(2)")).Click();
            vars["WindowHandles"] = driver.WindowHandles;
            driver.FindElement(By.CssSelector("#item_181 .w-80px")).Click();
            vars["win2179"] = waitForWindow(2000);
            driver.SwitchTo().Window(vars["win2179"].ToString());
            driver.FindElement(By.CssSelector(".product-details-section .col-xl-7")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".product-details-text > .title")).Text, Is.EqualTo("Laptop MSI Gaming GP76 11UG i7 11800H/ 16GB/ 1TB SSD/ 8GB RTX3070/ 240Hz/ Balo/ Chuột/ Win10 (435VN)"));
        }



        [Test]
        public void xemctspadmin()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_141 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_141 > td:nth-child(2)")).Text, Is.EqualTo("Laptop LG Gram 16 2021 i7 1165G7/16GB/512GB/Win10 (16Z90P-G.AH75A5)"));
            driver.FindElement(By.CssSelector("#item_141 .btn")).Click();
            Thread.Sleep(1000);
            IWebElement elm = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div[2]/div/div[1]/table/tbody/tr[6]/td[8]/div/div[1]/a"));
            elm.Click();
            driver.FindElement(By.CssSelector(".flex-sm-nowrap")).Click();
            Assert.That(driver.FindElement(By.LinkText("Laptop LG Gram 16 2021 i7 1165G7/16GB/512GB/Win10 (16Z90P-G.AH75A5)")).Text, Is.EqualTo("Laptop LG Gram 16 2021 i7 1165G7/16GB/512GB/Win10 (16Z90P-G.AH75A5)"));
            driver.FindElement(By.CssSelector(".row:nth-child(11) > .col-lg-8")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".row:nth-child(11) > .col-lg-8 > .fw-bold")).Text, Is.EqualTo("19:08 26-07-2021"));
        }



        [Test]
        public void ktraNutHanhDong()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_136 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_136 > td:nth-child(2)")).Text, Is.EqualTo("Ổ cứng HDD 1TB Seagate Backup Plus Slim STHN1000400 Đen"));
            driver.FindElement(By.CssSelector("#item_136 .btn")).Click();
            driver.FindElement(By.CssSelector(".flex-lg-grow-1")).Click();
            driver.FindElement(By.CssSelector(".fs-1 > img")).Click();
            driver.FindElement(By.LinkText("Trang chủ")).Click();
            driver.Close();
        }



        [Test]
        public void ktraButtonNext()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Text, Is.EqualTo("USB 2.0 8 GB Sandisk SDCZ50"));
            driver.FindElement(By.CssSelector(".next")).Click(); //len trang 2
            driver.FindElement(By.CssSelector("#item_115 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_115 > td:nth-child(2)")).Text, Is.EqualTo("Tai nghe chụp tai Gaming Rapoo VH160"));
            driver.FindElement(By.CssSelector(".next")).Click(); //len trang 3
            driver.FindElement(By.CssSelector("#item_94 > td:nth-child(2)")).Click();
            Thread.Sleep(2000);
            Assert.That(driver.FindElement(By.CssSelector("#item_94 > td:nth-child(2)")).Text, Is.EqualTo("Túi chống sốc Laptop 15 inch TOMTOC A13-E02G Xám"));
            driver.Close();
        }



        [Test]
        public void ktraButtonPrev()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            {
                var element = driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Text, Is.EqualTo("USB 2.0 8 GB Sandisk SDCZ50"));
            IWebElement elm2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div[2]/div/div[2]/div[2]/div/div/ul/li[7]/a"));
            elm2.Click(); //6
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".previous")).Click(); //5
            driver.FindElement(By.CssSelector(".previous")).Click(); //4
            Thread.Sleep(3000);
            driver.Close();
        }



        [Test]
        public void timIdSp()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector(".has-dropdown > a")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_146 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_146 > td:nth-child(2)")).Text, Is.EqualTo("Laptop Acer Swift 5 SF514 53T 51EX i5 8265U/8GB/256GB/Touch/Win10 (NX.H7KSV.001)"));
            driver.FindElement(By.CssSelector(".w-250px")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys("146");
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector("td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("td:nth-child(2)")).Text, Is.EqualTo("Laptop Acer Swift 5 SF514 53T 51EX i5 8265U/8GB/256GB/Touch/Win10 (NX.H7KSV.001)"));
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".container")).Click();
            driver.Close();
        }



        [Test]
        public void timTenSP()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_148 > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys("Laptop Lenovo ThinkBook 14 G2 ITL i7 1165G7/8GB/512GB/Win10 (20VD003LVN)");
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector("td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("td:nth-child(2)")).Text, Is.EqualTo("Laptop Lenovo ThinkBook 14 G2 ITL i7 1165G7/8GB/512GB/Win10 (20VD003LVN)"));
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".col-md-5")).Click();
        }



        [Test]
        public void ktraluotxemsp()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".menu-item:nth-child(6) path:nth-child(1)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.Id("item_181")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_181 > td:nth-child(6)")).Text, Is.EqualTo("162"));
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".pt-6")).Click();
        }



        [Test]
        public void ktrabuttontoheaderPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_131 > td:nth-child(2)")).Text, Is.EqualTo("USB 2.0 8 GB Sandisk SDCZ50"));
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#kt_scrolltop svg")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_181 > td:nth-child(2)")).Text, Is.EqualTo("Laptop MSI Gaming GP76 11UG i7 11800H/ 16GB/ 1TB SSD/ 8GB RTX3070/ 240Hz/ Balo/ Chuột/ Win10 (435VN)"));
            Thread.Sleep(3000);
        }



        [Test]
        public void ktraButtonSearch()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            {
                var element = driver.FindElement(By.Id("Email"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.CssSelector(".account_form > form"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".account_form > form")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_146 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_146 > td:nth-child(2)")).Text, Is.EqualTo("Laptop Acer Swift 5 SF514 53T 51EX i5 8265U/8GB/256GB/Touch/Win10 (NX.H7KSV.001)"));
            driver.FindElement(By.CssSelector(".w-250px")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys("122");
            driver.FindElement(By.CssSelector(".ms-6 > svg")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.LinkText("122")).Text, Is.EqualTo("122"));
            driver.Close();
        }



        [Test]
        public void actionTrash() //kiem tra nut hanh dong nut khoi phuc trong thung rac
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.LinkText("Hành động")).Click();
            driver.FindElement(By.CssSelector(".show > .menu-item:nth-child(1)")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.Id("avtivate__product-submit")).Text, Is.EqualTo("Khôi phục"));
        }




        [Test]
        public void buttonHuyKhoiPhuc()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.CssSelector("#item_144 > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".min-w-300px")).Click();
            driver.FindElement(By.LinkText("Hành động")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Khôi phục")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#activate #kt_modal_new_target_form .btn:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".page-title")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".fs-3")).Text, Is.EqualTo("Thùng rác: Danh sách sản phẩm"));
            Thread.Sleep(2000);
        }



        [Test]
        public void buttonTrash()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.LinkText("Sản phẩm")).Click();
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.CssSelector("#item_143 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_143 > td:nth-child(2)")).Text, Is.EqualTo("Laptop MSI Summit E13 Flip i7 1185G7/16GB/1TB SSD/Touch/Túi/Pen/Win10 (211VN)"));
            Thread.Sleep(3000);
        }



        [Test]
        public void chuyenTranginTrash()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.LinkText("Sản phẩm")).Click();
            {
                var element = driver.FindElement(By.LinkText("Sản phẩm"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.CssSelector("#item_3 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_3 > td:nth-child(2)")).Text, Is.EqualTo("Asus VivoBook X415EA i5 1135G7/8GB/512GB/Win10 (EB637T)"));
            driver.FindElement(By.LinkText("1")).Click();
            Assert.That(driver.FindElement(By.LinkText("1")).Text, Is.EqualTo("1"));
            driver.FindElement(By.CssSelector(".col-md-7")).Click();
            driver.FindElement(By.CssSelector(".card > .py-4")).Click();
            driver.FindElement(By.LinkText("2")).Click();
            driver.FindElement(By.CssSelector("td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("td:nth-child(2)")).Text, Is.EqualTo("Asus VivoBook A515EP i5 1135G7/8GB/512GB/2GB MX330/Win10 (BN334T)"));
            driver.FindElement(By.CssSelector(".container")).Click();
            Thread.Sleep(3000);
        }



        [Test]
        public void deleteSearchContent()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.CssSelector(".account_form > form")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.LinkText("Sản phẩm")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).Click();
            driver.FindElement(By.CssSelector(".w-250px")).SendKeys("Tai nghe chụp tai Gaming JBL QUANTUM 100");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".w-250px")).Click();
            Thread.Sleep(2000);
        }




        [Test]
        public void invalidAddsp()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.LinkText("Thêm mới")).Click();
            driver.FindElement(By.Id("product_name")).Click();
            driver.FindElement(By.Id("product_name")).SendKeys("Laptop B41");
            driver.FindElement(By.Id("price")).Click();
            driver.FindElement(By.Id("price")).SendKeys("23900000");
            driver.FindElement(By.Id("quantity")).Click();
            driver.FindElement(By.Id("quantity")).SendKeys("22");
            driver.FindElement(By.Id("disscount_id")).Click();
            {
                var dropdown = driver.FindElement(By.Id("disscount_id"));
                dropdown.FindElement(By.XPath("//option[. = 'Không giảm giá']")).Click();
            }
            driver.FindElement(By.Id("brand_id")).Click();
            {
                var dropdown = driver.FindElement(By.Id("brand_id"));
                dropdown.FindElement(By.XPath("//option[. = 'Acer']")).Click();
            }
            driver.FindElement(By.CssSelector(".row:nth-child(2) > .col-lg-4")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".row:nth-child(2) .col-form-label")).Text, Is.EqualTo("Danh mục"));
            driver.FindElement(By.CssSelector(".card-footer > .btn-primary")).Click();
            js.ExecuteScript("window.scrollTo(0,0)");
            Assert.That(driver.FindElement(By.Id("genre_id-error")).Text, Is.EqualTo("Vui lòng chọn thể loại"));
            driver.FindElement(By.CssSelector(".p-9")).Click();
        }



        [Test]
        public void ktraButtonAdd()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.LinkText("Thêm mới")).Click();
            //driver.FindElement(By.CssSelector(".page-title")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/form/div/div[1]/div/div[1]/h1")).Text, Is.EqualTo("Thêm sản phẩm"));
            driver.FindElement(By.Id("kt_content")).Click();
        }



        [Test]
        public void buttonUpdate()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector("#item_140 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_140 > td:nth-child(2)")).Text, Is.EqualTo("Laptop Lenovo IdeaPad 5 14ITL05 i5 1135G7/16GB/512GB/Win10 (82FE00KRVN)"));
            driver.FindElement(By.CssSelector("#item_140 .btn")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Chỉnh sửa")).Click();
            driver.FindElement(By.Id("kt_toolbar_container")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".fs-3")).Text, Is.EqualTo("Chỉnh sửa sản phảm"));
            driver.FindElement(By.CssSelector(".flex-sm-nowrap")).Click();
            Assert.That(driver.FindElement(By.LinkText("Laptop Lenovo IdeaPad 5 14ITL05 i5 1135G7/16GB/512GB/Win10 (82FE00KRVN)")).Text, Is.EqualTo("Laptop Lenovo IdeaPad 5 14ITL05 i5 1135G7/16GB/512GB/Win10 (82FE00KRVN)"));
            driver.FindElement(By.CssSelector(".p-9")).Click();
            driver.FindElement(By.CssSelector(".row:nth-child(13) > .col-lg-4")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".row:nth-child(13) .col-form-label")).Text, Is.EqualTo("Mô tả sản phẩm"));
            driver.FindElement(By.CssSelector(".card-footer")).Click();
        }



        [Test]
        public void buttonQuayLaiQLSP()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.CssSelector(".fs-3")).Click();
            driver.FindElement(By.CssSelector(".fs-3")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".fs-3")).Text, Is.EqualTo("Thùng rác: Danh sách sản phẩm"));
            driver.FindElement(By.CssSelector(".pt-6")).Click();
            driver.FindElement(By.LinkText("quay lại")).Click();
            {
                var element = driver.FindElement(By.LinkText("Thùng rác (16)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.Id("kt_toolbar_container")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".fs-3")).Text, Is.EqualTo("Danh sách sản phẩm"));
            driver.FindElement(By.CssSelector(".pt-6")).Click();
        }



        [Test]
        public void khoiPhucSp()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.CssSelector(".account_form > form")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.LinkText("Sản phẩm")).Click();
            driver.FindElement(By.LinkText("Thùng rác (16)")).Click();
            driver.FindElement(By.CssSelector("#item_144 > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#item_144 > td:nth-child(2)")).Text, Is.EqualTo("Laptop Apple MacBook Air M1 2020 8GB/512GB/Gold (MGNE3SA/A)"));
            driver.FindElement(By.CssSelector(".pt-6")).Click();
            driver.FindElement(By.LinkText("Hành động")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Khôi phục")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("avtivate__product-submit")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.Id("swal2-title")).Text, Is.EqualTo("Khôi phục thành công"));
        }


        [Test]
        public void awfsafad()
        {
            driver.Navigate().GoToUrl("https://localhost:44336/");
            driver.Manage().Window.Size = new System.Drawing.Size(1536, 816);
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.Name("dangnhap")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1");
            driver.FindElement(By.Name("Login2")).Click();
            driver.FindElement(By.CssSelector("nav li:nth-child(6) > a")).Click();
            driver.FindElement(By.CssSelector("#\\#kt_aside_menu > .menu-item:nth-child(4) .menu-title")).Click();
            driver.FindElement(By.CssSelector(".pt-6")).Click();
            {
                var element = driver.FindElement(By.LinkText("Thùng rác (16)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();

                string backgroundColor = element.GetCssValue("background-color");

                Assert.That(backgroundColor, Is.EqualTo("rgba(241, 65, 108, 1)"));
            }
            Thread.Sleep(3000);
        }

    }
}
