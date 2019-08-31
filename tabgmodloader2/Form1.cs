using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace tabgmodloader2
{


    public partial class main : Form
    {

        public string install;
        public bool log = false;

        public int UPDATEMEORDIE = 9;


        public main()
        {
            InitializeComponent();
            GetInstallPath();
            GetArgs();
            
            if (File.Exists(Path.GetTempPath() + @"dl.dll"))
            {
                File.Delete(Path.GetTempPath() + @"dl.dll");
            }
        }
        public void GetArgs()
        {
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if (arg == "-noupdate")
                {
                    MessageBox.Show("Updates temporarily disabled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CheckUpdate();
                }
                if (arg == "-conlog")
                {
                    MessageBox.Show("Console Logging Enabled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log = true;
                    AllocConsole();
                    Log("Console Logging Enabled!");
                }

            }
        }

        public void Log(string l)
        {
            if (log) {
                Console.WriteLine("[" + DateTime.UtcNow.Hour.ToString() + ":" +DateTime.UtcNow.Minute.ToString() + "." + DateTime.UtcNow.Millisecond.ToString() + "] " + l);
            }
        }

        public void CheckUpdate()
        {
            int temp;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/mhnd4414/tml/master/v");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            int.TryParse(content, out temp);
            if(temp != UPDATEMEORDIE)
            {
                DialogResult result = MessageBox.Show("An update is required before you can use TABG Mod Loader", "Update Available", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Process.Start("https://github.com/mhnd4414/tml");
                    Environment.Exit(11);
                }
                else
                {
                    Environment.Exit(12);
                }
            }
        }

        public void GetInstallPath()
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 823130", false);
            try { 
                install = (String)myKey.GetValue("InstallLocation");
            } catch
            {
                MessageBox.Show("Game not found in Steam Directory. The loader wont work properly!", "Warning!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                install = "Uh-oh...";
                //Environment.Exit(-1);
            }
            titlebarletters.Text += " | ";
            load.Text += install;
        }


        public void Progress(int p)
        {
            progressbar.Width = p*478/ 100;
            progressbar.BackColor = GetBlendedColor(p);
            return;
        }

        public Color GetBlendedColor(int percentage)
        {
            if (percentage < 50)
                return Interpolate(Color.Red, Color.Yellow, percentage / 50.0);
            return Interpolate(Color.Yellow, Color.Lime, (percentage - 50) / 50.0);
        }

        private Color Interpolate(Color color1, Color color2, double fraction)
        {
            double r = Interpolate(color1.R, color2.R, fraction);
            double g = Interpolate(color1.G, color2.G, fraction);
            double b = Interpolate(color1.B, color2.B, fraction);
            return Color.FromArgb((int)Math.Round(r), (int)Math.Round(g), (int)Math.Round(b));
        }

        private double Interpolate(double d1, double d2, double fraction)
        {
            return d1 + (d2 - d1) * fraction;
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage only when the value is not the same.
            Progress(e.ProgressPercentage);
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                System.IO.File.Copy(Path.GetTempPath() + @"dl.dll", install + @"\TotallyAccurateBattlegrounds_Data\Managed\Assembly-CSharp.dll", true);
                File.Delete(Path.GetTempPath() + @"dl.dll");
                try
                {
                    System.Diagnostics.Process.Start(@"steam://rungameid/823130");
                    Application.Exit();
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.ToString(), "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.ToString(), "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }











        // Titlebar Dragging Stuff

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Titlebarletters_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = tabgmodloader2.Properties.Resources.closeh;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = tabgmodloader2.Properties.Resources.close;
        }

        private void MinButton_MouseEnter(object sender, EventArgs e)
        {
            minButton.BackgroundImage = tabgmodloader2.Properties.Resources.minh;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinButton_MouseLeave(object sender, EventArgs e)
        {
            minButton.BackgroundImage = tabgmodloader2.Properties.Resources.min;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Load_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Vanilla_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadFile(@"http://github.com/wafflehammer/TabgGunGame/raw/master/latest.dll", Path.GetTempPath() + @"dl.dll");
            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.ToString(), "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modded_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadFile(@"http://github.com/wafflehammer/TabgGunGame/raw/master/Assembly-CSharp.dll", Path.GetTempPath() + @"dl.dll");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.ToString(), "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //console stuff
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
