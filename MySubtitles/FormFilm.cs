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
    public partial class FormFilm : Form
    {
        private string nazovFilmu;
        private string destFolder;
        private string a;
        string uzivatelMeno;
        string uzivatelHeslo;
        string f;
        string driver;
        string download;
        string cestaDrivera = @"";
        string cestaDownload = @"";
        // pre stiahnutie - cakanie
        string vysledok;
        // f - funguje
        // n - nefunguje
        int pocitadlo = 0;
        public FormFilm()
        {
            InitializeComponent();
        }
        
        public string DestFolder { get => destFolder; set => destFolder = value; }

        public string NazovFilmu { get => nazovFilmu; set => nazovFilmu = value; }
        public string A { get => a; set => a = value; }

 
        private void FormFilm_Load(object sender, EventArgs e)
        {
            uzivatelMeno = Settings.Default["Meno"].ToString();
            uzivatelHeslo = Settings.Default["Heslo"].ToString();
            f = Settings.Default["Farba"].ToString();
            driver = Settings.Default["ChromeDriver"].ToString();
            download = Settings.Default["DownloadPath"].ToString();
            cestaDrivera = cestaDrivera.Insert(0, driver);
            cestaDownload = cestaDownload.Insert(0, download);
            Settings.Default.Save();
            //MessageBox.Show(cestaDrivera);
            //MessageBox.Show(uzivatelMeno + " " + uzivatelHeslo);
            if (f == "z")
            {
                btn_Stiahnut.Image = Zelene.Download_green;
                btn_Premenovat.Image = Zelene.Premenovanie_green;
                btnPrehladavat.Image = Zelene.Bodky_green;

                lblNazovFilmu.ForeColor = Color.FromArgb(92, 225, 165);
                lblDestPath.ForeColor = Color.FromArgb(92, 225, 165);
                btn_Stiahnut.ForeColor = Color.FromArgb(92, 225, 165);
                btn_Premenovat.ForeColor = Color.FromArgb(92, 225, 165); 
                txtDP.ForeColor = Color.FromArgb(92, 225, 165);
                txtNazov.ForeColor = Color.FromArgb(92, 225, 165);

                txtDP.BackColor = Color.FromArgb(0, 100, 113);
                txtNazov.BackColor = Color.FromArgb(0, 100, 113);
                btnPrehladavat.BackColor = Color.FromArgb(0, 100, 113); // iba jeho lebo ostatne zostanu biele pri zmene farby
                this.BackColor = Color.FromArgb(0, 125, 113);

                lblNazovFilmu.BackColor = Color.FromArgb(60, 150, 138);
                lblDestPath.BackColor = Color.FromArgb(60, 150, 138);
            }
        }

        private void txtNazov_TextChanged(object sender, EventArgs e)
        {
            NazovFilmu = txtNazov.Text.Trim(); ; // ak sa to nachadza tu tak to nebudem asi vediet poslat inde!
            A = NazovFilmu; // premenná na uloženie nazvu filmu s velkymi zaciatocnymi pismenami
            // PREMENOVAT
            if (txtNazov.Text != "" && txtDP.Text != "") // keby to bolo v metode leave tak by sa zmena aplikovala až ked opustim textbox
            {
                btn_Premenovat.Enabled = true;
                if (f == "m")
                {
                    btn_Premenovat.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btn_Premenovat.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btn_Premenovat.Enabled = false;
                btn_Premenovat.BackColor = Color.White;
            }
            // STIAHNUT
            if(txtNazov.Text != "")
            {
                btn_Stiahnut.Enabled = true;
                if(f == "m")
                {
                    btn_Stiahnut.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                     btn_Stiahnut.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btn_Stiahnut.Enabled = false;
                btn_Stiahnut.BackColor = Color.White;
            }
        }

        private void txtDP_TextChanged(object sender, EventArgs e)
        {
            // tento textbox je iba ReadOnly, aby uzivatel nezadal hocico
            DestFolder = txtDP.Text;
            if (txtNazov.Text != "" && txtDP.Text != "") 
            {
                btn_Premenovat.Enabled = true;
                if (f == "m")
                {
                    btn_Premenovat.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btn_Premenovat.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btn_Premenovat.Enabled = false;
                btn_Premenovat.BackColor = Color.White;
            }
        }

        private void btn_Stiahnut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(uzivatelMeno + " " + uzivatelHeslo); 
            //ChromeDriver driver = new ChromeDriver(@"D:\chromedriver98");
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
                    if(pocitadlo >= 3)
                    {
                        ChyboveHlasenie chyboveHlasenie = new ChyboveHlasenie("Došlo k výskytu chyby pri načítaní stránky.");
                        chyboveHlasenie.Farba(f);
                        chyboveHlasenie.Show();
                        driver.Close();
                    }
                } while (vysledok == "n"); // do while len kvoli tomu aby to urobil 3krat inac do while ide do nekonecna
                
                try
                {
                    driver.FindElement(By.Id("log_login")).SendKeys(uzivatelMeno);
                    driver.FindElement(By.Id("log_password")).SendKeys(uzivatelHeslo);
                    driver.FindElement(By.Name("prihlasit")).Submit();
                }
                catch
                {
                    Prihlasenie prihlasenie = new Prihlasenie();
                    prihlasenie.Farba(f);
                    prihlasenie.Show();
                    driver.Close();
                }
                Task.Delay(10000).Wait();
                try
                {
                    driver.FindElement(By.Id("searchTitulky")).SendKeys(NazovFilmu);
                    driver.FindElements(By.CssSelector(".button_hledat"))[1].Click();
                    Task.Delay(2000).Wait();
                    driver.FindElement(By.XPath("//a[contains(text(),'Staž.')]")).Click();
                    driver.FindElement(By.XPath("//a[contains(text(),'Staž.')]")).Click();
                    driver.FindElement(By.LinkText(NazovFilmu)).Click(); // - tu to stoplo
                    WebElement w = (WebElement)driver.FindElement(By.LinkText(NazovFilmu));
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
            catch (Exception ex)
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
                else if(ex.Message.Contains("chromedriver.exe does not exist."))
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

        private void btn_Premenovat_Click(object sender, EventArgs e)
        {
            NazovFilmu = NazovFilmu.Replace(" ", ".").Replace(":", "").Replace("'", "").Replace(",", "").Replace("!", ".").Replace("- ", "").Replace("..", "."); // dont look up - vyriešiť apostrof
            string nazovTitulky = "";
            string rootPath = cestaDownload;
            string[] files = Directory.GetFiles(rootPath);
            string df = @"\"; //df - dest Folder
            df = df.Insert(0, destFolder);
            string[] fd = Directory.GetFiles(df); //fd - dest folder // dat fd do enable false aby tam nemohol pisat ale nechat farbu
            string meno;
            foreach (string file in fd)
            {
                meno = Path.GetFileNameWithoutExtension(file);
                if (meno.Contains(NazovFilmu))
                {
                    nazovTitulky = meno;
                }
            }
            if (nazovTitulky == "") // može sa stať, že subor .mkv je napísaný malym aj .nfo je malym preto nazov filmu dam tiež malým
            {
                foreach (string file in fd)
                {
                    meno = Path.GetFileNameWithoutExtension(file);
                    NazovFilmu = NazovFilmu.ToLower();
                    if (meno.Contains(NazovFilmu))
                    {
                        nazovTitulky = meno;
                    }
                }
            }
            A = A.Replace(" ", "-").Replace(":", "").Replace("'", "-").Replace(",", "").Replace("!", "-").Replace("- ", "").Replace(".", "-").Replace("--", "-"); // The Matrix Resurrections  --> The-Matrix-Resurrections (takto sa volaju titulky)
            bool vysledokPresuvania = true;
            foreach (string file in files) // .Replace("--","-") a .Replace(".","."), keď je napr, slovo P.S. (text) tak z toho vznikne P-S--(text) a to isté s bodkami
            {
                string nazov = Path.GetFileName(file);
                if (nazov.Contains(A))
                {
                    // File.Copy(file, $"{destFolder}{Path.GetFileName(file)}",false);
                    try
                    {
                        File.Move(file, $"{df}{nazovTitulky + ".srt"}");// tu dá chyba ak už existuje urobit catch
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
            foreach(string file in cielovyPriecinok)
            {
                string kontrola = Path.GetFileName(file);
                if(kontrola.Contains(NazovFilmu) && kontrola.Contains(".srt"))
                {
                    vysledok = true;
                }
            }
            if(vysledok && vysledokPresuvania)
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

        private void txtNazov_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtNazov_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
