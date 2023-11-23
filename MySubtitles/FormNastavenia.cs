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
using MySubtitles.Properties;

namespace MySubtitles
{
    public partial class FormNastavenia : Form
    {
        string volba;
        string f;
        string meno, heslo;
        public FormNastavenia()
        {
            InitializeComponent();
        }

        private void FormNastavenia_Load(object sender, EventArgs e)
        {
            f = Settings.Default["Farba"].ToString();
            Settings.Default.Save();
            //panel_Email1.Controls.Add(lblPozadie);
            if (f == "z")
            {
                toggleBtnBlue.Checked = false;
                toggleBtnGreen.Checked = true; // skusit urobit cez klik
                lblPozadie.ForeColor = Color.FromArgb(92, 225, 165);
                lblUdaje.ForeColor = Color.FromArgb(92, 225, 165);
                lblHeslo.ForeColor = Color.FromArgb(92, 225, 165);
                lblMeno.ForeColor = Color.FromArgb(92, 225, 165);
                txtMeno.ForeColor = Color.FromArgb(92, 225, 165);
                txtHeslo.ForeColor = Color.FromArgb(92, 225, 165);
                txtMeno.BackColor = Color.FromArgb(0, 100, 113);
                txtHeslo.BackColor = Color.FromArgb(0, 100, 113);
                btnUlozit.ForeColor = Color.FromArgb(92, 225, 165);
                this.BackColor = Color.FromArgb(0, 125, 113);
                //lblPozadie.BackColor = Color.FromArgb(45, 162, 138);
                lblPozadie.BackColor = Color.FromArgb(60, 150, 138);
                lblUdaje.BackColor = Color.FromArgb(60, 150, 138);
                lblHeslo.BackColor = Color.FromArgb(60, 150, 138);
                lblMeno.BackColor = Color.FromArgb(60, 150, 138);
                lblChrome.ForeColor = Color.FromArgb(92, 225, 165);
                lblChrome.BackColor = Color.FromArgb(60, 150, 138);
                btnPrehladavat.BackColor = Color.FromArgb(0, 100, 113); 
                btnUlozitDriver.ForeColor = Color.FromArgb(92, 225, 165);
                txtCesta.ForeColor = Color.FromArgb(92, 225, 165);
                txtCesta.BackColor = Color.FromArgb(0, 100, 113);
                btnPrehladavat.Image = Zelene.Bodky_green;
            }
            if(toggleBtnBlue.Checked && !toggleBtnGreen.Checked) // aby sa nestalo, že su obidva zapnuté alebo vypnuté
            {
                toggleBtnBlue.Enabled = false;
            }
            else
            {
                toggleBtnGreen.Enabled = false;
            }
        }

        private void toggleBtnBlue_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void toggleBtnBlue_Click_1(object sender, EventArgs e)
        {
            if (toggleBtnBlue.Checked)
            {
                toggleBtnGreen.Checked = false;
                Thread.Sleep(1000);
                volba = "m"; // modra
                Settings.Default["Farba"] = volba;
                Settings.Default.Save();
                MojeTitulky.ActiveForm.Hide();
                MojeTitulky form1 = new MojeTitulky();
                form1.Show();
            }
        }

        private void txtMeno_TextChanged(object sender, EventArgs e)
        {
            meno = txtMeno.Text;
            if(txtMeno.Text != "" && txtHeslo.Text != "")
            {
                btnUlozit.Enabled = true;
                if (f == "m")
                {
                    btnUlozit.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnUlozit.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnUlozit.Enabled = false;
                btnUlozit.BackColor = Color.White;
            }
        }

        private void txtHeslo_TextChanged(object sender, EventArgs e)
        {
            heslo = txtHeslo.Text;
            if (txtMeno.Text != "" && txtHeslo.Text != "")
            {
                btnUlozit.Enabled = true;
                if (f == "m")
                {
                    btnUlozit.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnUlozit.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
            else
            {
                btnUlozit.Enabled = false;
                btnUlozit.BackColor = Color.White;
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            Settings.Default["Meno"] = txtMeno.Text;
            Settings.Default["Heslo"] = txtHeslo.Text;
            /*VyplnanieUdajov vyplnanieUdajov = new VyplnanieUdajov("Uloženie údajov prebehlo úspešne.");
            vyplnanieUdajov.Farba(f);
            vyplnanieUdajov.Show();*/ // nenacíta pekne - vyriesiť!
            if (toggleBtnBlue.Checked)
            {
                volba = "m";
            }
            else
            {
                volba = "z";
            }
            Settings.Default["Farba"] = volba;
            Settings.Default.Save();
            MojeTitulky.ActiveForm.Hide();
            MojeTitulky form1 = new MojeTitulky();
            form1.Show();
        }

        private void btnPrehladavat_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Vyberte priečinok s aktuálnym chromedriverom."})
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtCesta.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnUlozitDriver_Click(object sender, EventArgs e)
        {
            Settings.Default["ChromeDriver"] = txtCesta.Text;
            Hlasenie hlasenie = new Hlasenie("Uloženie údajov prebehlo úspešne.");
            hlasenie.Farba(f);
            hlasenie.Show();
        }

        private void txtCesta_TextChanged(object sender, EventArgs e)
        {
            if(txtCesta.Text != "")
            {
                btnUlozitDriver.Enabled = true;
                if (f == "m")
                {
                    btnUlozitDriver.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnUlozitDriver.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
        }

        private void panel_Webdriver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDownloads_TextChanged(object sender, EventArgs e)
        {
            if (txtDownloads.Text != "")
            {
                btnUlozitDownload.Enabled = true;
                if (f == "m")
                {
                    btnUlozitDownload.BackColor = Color.FromArgb(24, 30, 54);
                }
                else
                {
                    btnUlozitDownload.BackColor = Color.FromArgb(0, 100, 113);
                }
            }
        }

        private void btnPrehladavatDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Vyberte priečinok kam chcete sťahovať titulky." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDownloads.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnUlozitDownload_Click(object sender, EventArgs e)
        {
            Settings.Default["DownloadPath"] = txtDownloads.Text;
            Hlasenie hlasenie = new Hlasenie("Uloženie údajov prebehlo úspešne.");
            hlasenie.Farba(f);
            hlasenie.Show();
        }

        private void toggleBtnGreen_Click(object sender, EventArgs e)
        {
            if (toggleBtnGreen.Checked)
            {
                toggleBtnBlue.Checked = false;
                Thread.Sleep(1000);
                volba = "z";// zelena
                Settings.Default["Farba"] = volba;
                Settings.Default.Save();
                MojeTitulky.ActiveForm.Hide(); // skryje existujúcu formu1 - prišiel som na to sam xd
                MojeTitulky form1 = new MojeTitulky();
                form1.Show();
            }
        }
    }
}
