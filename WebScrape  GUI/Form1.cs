using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebScrape__GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string rootFolder = @"C:\Users\TTefera\source\repos\WebScrape  GUI\WebScrape  GUI\bin\Debug\";
            string authorsFile = "intImg.png";
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, authorsFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, authorsFile));
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            string userInput = txtSearch.Text.Trim();
            ChromeOptions co = new ChromeOptions();
            co.AddArgument("--headless");


            IWebDriver driver = new ChromeDriver(co);

            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            var element = driver.FindElement(By.Id("searchInput"));
            element.SendKeys(userInput);
            element.Submit();


            var result = driver.FindElement(By.XPath("//*[@id=\"mw-content-text\"]/div[1]/p[3]"));
            lblOutput.Text = result.Text;


            var image = driver.FindElement(By.ClassName("thumbborder"));
            String src = image.GetAttribute("src");

            WebClient downloader = new WebClient();
            downloader.DownloadFile(src, "intImg" + ".png");

            pbxImage.ImageLocation = @"C:\Users\TTefera\source\repos\WebScrape  GUI\WebScrape  GUI\bin\Debug\intImg.png";


            driver.Navigate().GoToUrl("https://www.worldometers.info/coronavirus/country/"+userInput);
            var totalCases = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[1]/div/div[4]/div/span"));
            var deaths = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[1]/div/div[5]/div/span"));
            var recovered = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[1]/div/div[6]/div/span"));

            lblCovid.Text = "Cases: " + totalCases.Text + "\nDeaths: " + deaths.Text + "\nRecovered: " + recovered.Text;


        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if(btnTheme.BackColor != Color.WhiteSmoke)
            {
                btnTheme.BackColor = Color.WhiteSmoke;
                btnTheme.ForeColor = Color.Black;
                btnTheme.Text = "W";

                this.BackColor = Color.FromArgb(64, 64, 64);
                lblCovid.BackColor = Color.FromArgb(54, 54, 54);
                lblCovid.ForeColor = Color.WhiteSmoke;

                lblOutput.BackColor = Color.FromArgb(54, 54, 54);
                lblOutput.ForeColor = Color.WhiteSmoke;

                btnGo.BackColor = Color.SteelBlue;
                btnGo.ForeColor = Color.WhiteSmoke;

                txtSearch.BackColor = Color.FromArgb(54, 54, 54);
                txtSearch.ForeColor = Color.Coral;
                pnlCustom.BackColor = Color.FromArgb(54, 54, 54);
            }
            else
            {
                btnTheme.BackColor = Color.FromArgb(54,54,54);
                btnTheme.ForeColor = Color.White;
                btnTheme.Text = "B";

                this.BackColor = Color.FromName("Control");
                lblCovid.BackColor = Color.WhiteSmoke;
                lblCovid.ForeColor = Color.Black;

                lblOutput.BackColor = Color.WhiteSmoke;
                lblOutput.ForeColor = Color.Black;

                btnGo.BackColor = Color.SteelBlue;
                btnGo.ForeColor = Color.White;

                txtSearch.BackColor = Color.White;
                txtSearch.ForeColor = Color.Black;
                pnlCustom.BackColor = Color.White;
            }
        }

        private void openWiki(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wikipedia.org/");
        }
    }
}
