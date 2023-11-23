using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using MySubtitles.Properties;

namespace MySubtitles
{
    public partial class FormSerial : Form
    {
        private string nazovSerialu;
        private string se; //sezóna + epizóda
        private string destFolder;
        private string b;
        private string c;
        string uzivatelM;
        string uzivatelH;
        string f;
        string driver;
        string download;
        string cestaDrivera = @"";
        string cestaDownload = @"";
        string vysledok;
        int pocitadlo = 0;

        public string NazovSerialu { get => nazovSerialu; set => nazovSerialu = value; }
        public string Se { get => se; set => se = value; }
        public string DestFolder { get => destFolder; set => destFolder = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }


        public FormSerial()
        {
            InitializeComponent();
        }

       
        private void FormSerial_Load(object sender, EventArgs e)
        {
            uzivatelM = Settings.Default["Meno"].ToString();
            uzivatelH = Settings.Default["Heslo"].ToString();
            f = Settings.Default["Farba"].ToString();
            driver = Settings.Default["ChromeDriver"].ToString();
            download = Settings.Default["DownloadPath"].ToString();
            cestaDrivera = cestaDrivera.Insert(0, driver);
            cestaDownload = cestaDownload.Insert(0, download);
            Settings.Default.Save();
            //MessageBox.Show(uzivatelM + " " + uzivatelH);
            if (f == "z")
            {
                btnStiahnut.Image = Zelene.Download_green;
                btnPremenovat.Image = Zelene.Premenovanie_green;
                btnPrehladavat.Image = Zelene.Bodky_green;

                lblSE.ForeColor = Color.FromArgb(92, 225, 165);
                lblNazovSerial.ForeColor = Color.FromArgb(92, 225, 165);
                lblDestPath.ForeColor = Color.FromArgb(92, 225, 165);
                btnStiahnut.ForeColor = Color.FromArgb(92, 225, 165);
                btnPremenovat.ForeColor = Color.FromArgb(92, 225, 165);
                txtDP.ForeColor = Color.FromArgb(92, 225, 165);
                txtNazov.ForeColor = Color.FromArgb(92, 225, 165);
                txtSE.ForeColor = Color.FromArgb(92, 225, 165);
                txtSE.BackColor = Color.FromArgb(0, 100, 113);
                txtDP.BackColor = Color.FromArgb(0, 100, 113);
                txtNazov.BackColor = Color.FromArgb(0, 100, 113);
                btnPrehladavat.BackColor = Color.FromArgb(0, 100, 113);
                this.BackColor = Color.FromArgb(0, 125, 113);
                lblNazovSerial.BackColor = Color.FromArgb(60, 150, 138);
                lblSE.BackColor = Color.FromArgb(60, 150, 138);
                lblDestPath.BackColor = Color.FromArgb(60, 150, 138);
            }
        }

        private void txtNazov_TextChanged(object sender, EventArgs e)
        {
            NazovSerialu = txtNazov.Text.Trim(); ;
            B = NazovSerialu;
            if (txtNazov.Text != "" && txtSE.Text != "" && txtDP.Text != "")
            {
                btnPremenovat.Enabled = true;
                if (f == "m")
                {
                    btnPremenovat.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnPremenovat.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnPremenovat.Enabled = false;
                btnPremenovat.BackColor = Color.White;
            }
            if(txtNazov.Text != "" && txtSE.Text != "")
            {
                btnStiahnut.Enabled = true;
                if (f == "m")
                {
                    btnStiahnut.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnStiahnut.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnStiahnut.Enabled = false;
                btnStiahnut.BackColor = Color.White;
            }
        }

        private void txtSE_TextChanged(object sender, EventArgs e)
        {
            Se = txtSE.Text.Trim();
            C = Se; // služi na uloženie veľkych pismen
            // PREMENOVAT
            if (txtNazov.Text != "" && txtSE.Text != "" && txtDP.Text != "")
            {
                btnPremenovat.Enabled = true;
                if (f == "m")
                {
                    btnPremenovat.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnPremenovat.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnPremenovat.Enabled = false;
                btnPremenovat.BackColor = Color.White;
            }
            // STIAHNUT
            if (txtNazov.Text != "" && txtSE.Text != "")
            {
                btnStiahnut.Enabled = true;
                if (f == "m")
                {
                    btnStiahnut.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnStiahnut.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnStiahnut.Enabled = false;
                btnStiahnut.BackColor = Color.White;
            }
        }

        private void txtDP_TextChanged(object sender, EventArgs e)
        {
            // tento textBox je iba ReadOnly
            DestFolder = txtDP.Text;
            if (txtNazov.Text != "" && txtSE.Text != "" && txtDP.Text != "")
            {
                btnPremenovat.Enabled = true;
                if (f == "m")
                {
                    btnPremenovat.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnPremenovat.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnPremenovat.Enabled = false;
                btnPremenovat.BackColor = Color.White;
            }
        }

        private void panel_Serial_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnStiahnut_Click(object sender, EventArgs e)
        {
            //verziaPrehliadaca = driver.Capabilities["browserVersion"].ToString();
            //verziaDrivera = driver.Capabilities["browserName"].ToString();

            ChromeDriver driver = null;
            try
            {
                driver = new ChromeDriver(cestaDrivera);
                do
                {
                    try
                    {
                        driver.Navigate().GoToUrl("https://www.titulky.com/");
                        driver.Manage().Window.Maximize();
                        vysledok = "f"; // funguje
                    }
                    catch
                    {
                        Task.Delay(2000).Wait();
                        vysledok = "n";
                    }
                    pocitadlo++;
                    if (pocitadlo >= 3)
                    {
                        ChyboveHlasenie chyboveHlasenie = new ChyboveHlasenie("Došlo k výskytu chyby pri načítaní stránky.");
                        chyboveHlasenie.Farba(f);
                        chyboveHlasenie.Show();
                        driver.Close();
                    }
                } while (vysledok == "n");
                try
                {
                    driver.FindElement(By.Id("log_login")).SendKeys(uzivatelM);
                    driver.FindElement(By.Id("log_password")).SendKeys(uzivatelH);
                    driver.FindElement(By.Name("prihlasit")).Submit();
                }
                catch
                {
                    Prihlasenie prihlasenie = new Prihlasenie();
                    prihlasenie.Farba(f);
                    prihlasenie.Show();
                    driver.Close();
                }
                Task.Delay(10000).Wait();// VELMI DOLEZITE, ak by som to tam nemal tak nenajde elemt s id searchTitulky, pretože on už hladá s stránka sa ešte načítava
                try
                {

                    driver.FindElement(By.Id("searchTitulky")).SendKeys(NazovSerialu + " " + Se);
                    driver.FindElements(By.CssSelector(".button_hledat"))[1].Click();
                    //driver.FindElement(By.Id("search_submit")).Click();
                    Task.Delay(2000).Wait();
                    driver.FindElement(By.XPath("//a[contains(text(),'Staž.')]")).Click();
                    driver.FindElement(By.XPath("//a[contains(text(),'Staž.')]")).Click();
                    driver.FindElement(By.LinkText(NazovSerialu + " " + Se)).Click(); // - tu to stoplo
                    WebElement w = (WebElement)driver.FindElement(By.LinkText(NazovSerialu + " " + Se));
                    string a = w.GetAttribute("href");
                    Task.Delay(4000).Wait();
                    driver.Navigate().GoToUrl(a);
                    Task.Delay(2000).Wait();
                    try
                    {
                        driver.FindElement(By.Id("downdiv")).Click();
                    }
                    catch // V pripade ze sa vyskytne captcha!!
                    {
                        Task.Delay(20000).Wait();
                        driver.FindElement(By.Id("downdiv")).Click();
                    }
                    Hlasenie hlasenie = new Hlasenie("Download prebehol úspešne.");
                    hlasenie.Farba(f);
                    hlasenie.Show();
                    Task.Delay(2000).Wait();
                    driver.Close();
                }
                catch
                {
                    Nenaslo nenaslo = new Nenaslo();
                    nenaslo.Farba(f);
                    nenaslo.Show();
                    driver.Close();
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("unknown error"))
                {
                    NacitanieStranky nacitanieStranky = new NacitanieStranky("Prosím nainštalujte si prehliadač Google Chrome.");
                    nacitanieStranky.Farba(f);
                    nacitanieStranky.Show();
                }
                else if (ex.Message.Contains("version"))
                {
                    NacitanieStranky nacitanieStranky = new NacitanieStranky("Prosím aktualizujte si prehliadač Google Chrome.");
                    nacitanieStranky.Farba(f);
                    nacitanieStranky.Show();
                }
                else if (ex.Message.Contains("chromedriver.exe does not exist."))
                {
                    NacitanieStranky nacitanieStranky = new NacitanieStranky("Priečinok, ktorý ste si zvolili neobsahuje chromedriver.");
                    nacitanieStranky.Farba(f);
                    nacitanieStranky.Show();
                }
                /*if (driver != null)
                {
                    driver.Close();
                }*/
            }
        }

        private void btnPremenovat_Click(object sender, EventArgs e)
        {
            NazovSerialu = NazovSerialu.Replace(" ", ".").Replace(":", "").Replace("'", "").Replace(",", "").Replace("!", ".").Replace("- ", "").Replace("..", "."); // The Queen's Gambit - vyriešiť aj tu apostrof
            // urobit catch na nazovSerialu ak tam nic nezada a stlaci btn
            string nazovTitulky = "";
            string rootPath = cestaDownload;
            string[] files = Directory.GetFiles(rootPath);
            string df = @"\";
            df = df.Insert(0, DestFolder);
            // to iste aj pre destFolder
            string[] fd = Directory.GetFiles(df);
            foreach (string file in fd) // Urobit novu formu iba pre folder v ktorom ma uzivatel stiahnutu celu seriu!!!!!
            {
                string meno = Path.GetFileNameWithoutExtension(file);
                if (meno.Contains(NazovSerialu) && meno.Contains(Se))
                {
                    nazovTitulky = meno;
                }
            }
            if (nazovTitulky == "")
            {
                foreach (string file in fd)
                {
                    string meno = Path.GetFileNameWithoutExtension(file);
                    NazovSerialu = NazovSerialu.ToLower();
                    Se = Se.ToLower();
                    // aj se urobit catch!!
                    if (meno.Contains(NazovSerialu) && meno.Contains(Se))
                    {
                        nazovTitulky = meno;
                    }
                }
            }
            B = B.Replace(" ", "-").Replace(":", "").Replace("'", "-").Replace(",", "").Replace("!", "-").Replace("- ", "").Replace("--", "-"); // poslený replace ešte nemám odskúšanný
            bool vysledokPresuvania = true;
            foreach (string file in files)
            {
                string nazov = Path.GetFileName(file);
                if (nazov.Contains(B) && nazov.Contains(C))
                {
                    // File.Copy(file, $"{destFolder}{Path.GetFileName(file)}",false);
                    try
                    {
                        File.Move(file, $"{df}{nazovTitulky + ".srt"}");
                    }
                    catch
                    {
                        PresuvanieTitulkov presuvanieTitulkov = new PresuvanieTitulkov();
                        presuvanieTitulkov.Farba(f);
                        presuvanieTitulkov.Show();
                        vysledokPresuvania = false; // false - nastala chyba
                    }
                }
            }
            // KONTROLA
            string[] cielovyPriecinok = Directory.GetFiles(df); // musim ho znovu vytvorit, aby sa aplikovali zmeny(pridanie suboru .srt)!!!
            bool vysledok = false;
            foreach (string file in cielovyPriecinok)
            {
                string kontrola = Path.GetFileName(file); // GetFileName je aj s koncovkou (without je bez)
                if (kontrola.Contains(nazovSerialu) && kontrola.Contains(se) && kontrola.Contains(".srt"))
                {
                    vysledok = true;
                }
            }
            if (vysledok && vysledokPresuvania)
            {
                Hlasenie hlasenie = new Hlasenie("Premenovanie titulkov prebehlo úspešne.");
                hlasenie.Farba(f);
                hlasenie.Show();
            }
            if(!vysledok)
            {
                ChybaPremenovanie chyba = new ChybaPremenovanie();
                chyba.Farba(f);
                chyba.Show();
            }
        }

        private void btnPrehladavat_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Vyberte si cieľový priečinok." }) 
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDP.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
