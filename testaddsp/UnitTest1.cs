using ClosedXML.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;


namespace testaddsp
{
    public class Tests
    {
        public IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44336/");
            IWebElement elmDangNhap = driver.FindElement(By.Name("dangnhap"));
            elmDangNhap.Click();
            IWebElement elmMail = driver.FindElement(By.Name("Email"));
            IWebElement elmPass = driver.FindElement(By.Name("Password"));
            IWebElement btnLogin = driver.FindElement(By.Name("Login2"));

            if (elmMail != null && elmPass != null)
            {
                elmMail.SendKeys("admin@gmail.com");
                elmPass.SendKeys("1");
                btnLogin.Click();
            }
            
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();

        }

        [Test]
        public void Test1()
        {
            using (var workbook = new XLWorkbook("D:/DBCLPM/datatestaddsp.xlsx"))
            {
                var worksheet = workbook.Worksheet(1);
                int rowCount = worksheet.RowsUsed().Count();
                for (int row = 2; row <= rowCount; row++)
                {
                    Thread.Sleep(2000);
                    IWebElement elmPanel = driver.FindElement(By.XPath("/html/body/header/div/div/div/div/div/div[2]/nav/ul/li[6]/a"));
                    if (elmPanel != null)
                    {
                        elmPanel.Click();
                        Thread.Sleep(2000);

                        IWebElement btnQlsp = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/div[4]/a/span[2]"));
                        if (btnQlsp != null)
                        {
                            btnQlsp.Click();

                            IWebElement elmAddsp = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div/div/div[1]/div[2]/div/a[2]"));
                            elmAddsp.Click();

                            string danhMuc = worksheet.Cell(row, 1).GetString();
                            string thuongHieu = worksheet.Cell(row, 2).GetString();
                            string giamGia = worksheet.Cell(row, 3).GetString();
                            string name = worksheet.Cell(row, 4).GetString();
                            string giaBan = worksheet.Cell(row, 5).GetString();
                            string soLuong = worksheet.Cell(row, 6).GetString();
                            string anh = worksheet.Cell(row, 7).GetString();
                            string thongSoKT = worksheet.Cell(row, 8).GetString();
                            string moTaSP = worksheet.Cell(row, 9).GetString();
                            string kqMongMuon = worksheet.Cell(row, 10).GetString();

                            Thread.Sleep(2000);
                            IWebElement elmDanhMuc = driver.FindElement(By.Name("genre_id"));
                            IWebElement elmThuongHieu = driver.FindElement(By.Name("brand_id"));
                            IWebElement elmGiamGia = driver.FindElement(By.Name("disscount_id"));
                            IWebElement elmName = driver.FindElement(By.Name("product_name"));
                            IWebElement elmGia = driver.FindElement(By.Name("price"));
                            IWebElement elmSoLuong = driver.FindElement(By.Name("quantity"));
                            Thread.Sleep(5000);
                            IWebElement elmThongSo = driver.FindElement(By.CssSelector(".ck-focused"));//XPath("/html/body/div[1]/div/div[2]/div[2]/form/div/div[2]/div/div/div/div[1]/div[11]/div[2]/div/div[2]/div"));
                            IWebElement elmMota = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/form/div/div[2]/div/div/div/div[1]/div[12]/div[2]/div/div[2]/div"));
                            IWebElement elmSave = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/form/div/div[2]/div/div/div/div[2]/button[2]"));
                            By elmUploadAnh = By.Name("ImageUpload");

                            SelectElement selectDanhMuc = new SelectElement(elmDanhMuc);
                            //selectDanhMuc.SelectByValue(danhMuc);
                            selectDanhMuc.SelectByText(danhMuc);

                            SelectElement selectThuongHieu = new SelectElement(elmThuongHieu);
                            //selectThuongHieu.SelectByValue(thuongHieu);
                            selectThuongHieu.SelectByText(thuongHieu);

                            SelectElement selectGiamGia = new SelectElement(elmGiamGia);
                            //selectGiamGia.SelectByValue(giamGia);
                            selectGiamGia.SelectByText(giamGia);

                            elmName.SendKeys(name);
                            elmGia.SendKeys(giaBan);
                            elmSoLuong.SendKeys(soLuong);
                            elmThongSo.SendKeys(thongSoKT);
                            elmMota.SendKeys(moTaSP);

                            string urlAnh = anh;

                            driver.FindElement(elmUploadAnh).SendKeys(urlAnh);
                            Thread.Sleep(3000);

                            elmSave.Click();

                            IWebElement resultElement = null;
                            try
                            {
                                IWebElement elmgenre_error = driver.FindElement(By.Id("genre_id-error"));
                                if (elmgenre_error.Text == "Vui lòng chọn thể loại")
                                {
                                    resultElement = driver.FindElement(By.Id("genre_id-error"));
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                IWebElement elmbrand_error = driver.FindElement(By.Id("brand_id-error"));
                                if (elmbrand_error.Text == "Vui lòng chọn thương hiệu")
                                {
                                    resultElement = driver.FindElement(By.Id("brand_id-error"));
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                IWebElement elmdiscound_error = driver.FindElement(By.Id("disscount_id-error"));
                                if (elmdiscound_error != null && elmdiscound_error.Text == "Vui lòng chọn chương trình giảm giá")
                                {
                                    resultElement = driver.FindElement(By.Id("disscount_id-error"));
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                IWebElement elmproductname_error = driver.FindElement(By.Id("product_name-error"));
                                if (elmproductname_error != null && elmproductname_error.Text == "Vui lòng nhập tên sản phẩm")
                                {
                                    resultElement = driver.FindElement(By.Id("product_name-error"));
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                IWebElement elmprice_error = driver.FindElement(By.Id("price-error"));
                                if (elmprice_error.Text == "Vui lòng nhập giá")
                                {
                                    resultElement = driver.FindElement(By.Id("price-error"));
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                IWebElement elmquantity_error = driver.FindElement(By.Id("quantity-error"));
                                if (elmquantity_error.Text == "Vui lòng nhập số lượng")
                                {
                                    resultElement = driver.FindElement(By.Id("quantity-error"));
                                }
                            }
                            catch
                            {

                            }
                            if (resultElement == null)
                            {
                                resultElement = driver.FindElement(By.Id("swal2-title"));
                            }
                            string actualResult = resultElement.Text;
                            if (actualResult.Equals(kqMongMuon))
                            {
                                worksheet.Cell(row, 12).Value = "Passed";
                                worksheet.Cell(row, 11).Value = actualResult;
                            }
                            else
                            {
                                worksheet.Cell(row, 12).Value = "Failed";
                                worksheet.Cell(row, 11).Value = actualResult;
                            }
                        }

                        driver.Quit();
                        driver = new ChromeDriver();
                        driver.Navigate().GoToUrl("https://localhost:44336/");
                        driver.Manage().Window.Maximize();
                        Thread.Sleep(5000);
                        IWebElement elmDangNhap = driver.FindElement(By.Name("dangnhap"));
                        elmDangNhap.Click();
                        IWebElement elmMail = driver.FindElement(By.Name("Email"));
                        IWebElement elmPass = driver.FindElement(By.Name("Password"));
                        IWebElement btnLogin = driver.FindElement(By.Name("Login2"));

                        if (elmMail != null && elmPass != null)
                        {
                            elmMail.SendKeys("admin@gmail.com");
                            elmPass.SendKeys("1");
                            btnLogin.Click();
                        }
                    }
                    workbook.Save();
                }
                Assert.Pass();
            }
        }
    }
}