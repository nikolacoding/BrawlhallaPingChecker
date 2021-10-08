using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace BrawlhallaPingChecker
{
    public partial class Form1 : Form
    {
        private float totalQuickPing = 0f;
        private float averageQuickPing = 0f;
        private int QuickPingIterations = 0;
        private long maxQuickPing = 0;

        private float totalTenPing = 0f;
        private float averageTenPing = 0f;
        private int TenPingIterations = 0;
        private long maxTenPing = 0;

        private long pingBuffer;
        private string pingString;

        private const string ttBytes = "1122334455667788";
        private const string sfBytes = "11112222333344445555666677778888";

        enum State
        {
            Idle,
            Testing
        }

        private static string serverURL;

        State state;

        Button[] MainButtons;
        Button[] TestButtons;

        PictureBox[] TenPingsIcons;

        public Form1()
        {
            state = State.Idle;
            InitializeComponent();
            backButton.Enabled = false;
            pingString = ttBytes;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            MainButtons = new Button[7]{
                    EUbutton, USEbutton, USWbutton, SEAbutton, AUSbutton, BRZbutton, JPNbutton
                };

            TestButtons = new Button[2]{
                    QuickPingButton, TenPingsButton
                };

            TenPingsIcons = new PictureBox[] {
                    pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                    pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                    pictureBox11, pictureBox12
                };

            foreach (Button item in TestButtons)
            {
                item.Enabled = false;
            }

            foreach (PictureBox item in TenPingsIcons)
            {
                item.Visible = false;
            }

            SmallByteButton.Enabled = false;
            byteCount.Text = "32 bytes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EUbutton_Click(object sender, EventArgs e) => GoToPingTest("EU");
        private void USEbutton_Click(object sender, EventArgs e) => GoToPingTest("USE");
        private void USWbutton_Click(object sender, EventArgs e) => GoToPingTest("USW");
        private void BRZbutton_Click(object sender, EventArgs e) => GoToPingTest("BRZ");
        private void SEAbutton_Click(object sender, EventArgs e) => GoToPingTest("SEA");
        private void AUSbutton_Click(object sender, EventArgs e) => GoToPingTest("AUS");
        private void JPNbutton_Click(object sender, EventArgs e) => GoToPingTest("JPN");

        private void GoToPingTest(string server)
        {
            label3.Text = server switch
            {
                "USE" => "Selected server: US-E",
                "USW" => "Selected server: US-W",
                _ => "Selected server: " + server
            };

            serverURL = server switch
            {
                "EU" => "pingtest-ams.brawlhalla.com",
                "USE" => "pingtest-atl.brawlhalla.com",
                "USW" => "pingtest-cal.brawlhalla.com",
                "BRZ" => "pingtest-brs.brawlhalla.com",
                "SEA" => "pingtest-sgp.brawlhalla.com",
                "AUS" => "pingtest-aus.brawlhalla.com",
                "JPN" => "pingtest-jpn.brawlhalla.com",
                _ => "pingtest-ams.brawlhalla.com"
            };
            backButton.Enabled = true;
            foreach (Button item in MainButtons)
            {
                item.Enabled = false;
            }
            foreach (Button item in TestButtons)
            {
                item.Enabled = true;
            }
            state = State.Testing;
        }

        private void GoBack()
        {
            label3.Text = "Selected server: none";
            backButton.Enabled = false;
            foreach (Button item in MainButtons)
            {
                item.Enabled = true;
            }
            foreach (Button item in TestButtons)
            {
                item.Enabled = false;
            }
            state = State.Idle;
            ResetPings();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (state == State.Testing)
            {
                GoBack();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.twitter.com/nikolaSsBH");
            }
            catch {}
        }

        private void QuickPingButton_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();

            PingOptions pingoptions = new PingOptions
            {
                DontFragment = true
            };

            string data = "aaaaaaaaaaaaaaaa";
            int timeout = 350;
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            
            PingReply reply = ping.Send(serverURL, timeout, buffer, pingoptions);

            if (reply.Status == IPStatus.Success)
            {
                long currentPing = reply.RoundtripTime;
                quiPing.Text = currentPing.ToString("0") + "ms";

                totalQuickPing += Convert.ToInt16(currentPing);
                pingBuffer = currentPing;
                QuickPingIterations++;
                averageQuickPing = totalQuickPing / QuickPingIterations;

                quiPingAvg.Text = averageQuickPing.ToString("0") + "ms";

                if (currentPing > maxQuickPing)
                {
                    maxQuickPing = currentPing;

                    quiPingHigh.Text = maxQuickPing.ToString("0") + "ms";
                }
            }
            else
            {
                quiPing.Text = "*" + pingBuffer.ToString("0") + "ms";
            }
        }

        private async void TenPingsButton_Click(object sender, EventArgs e)
        {
            tenPingsLoss.Text = "N/A";
            foreach (PictureBox item in TenPingsIcons)
            {
                item.Visible = false;
            }

            Ping ping = new Ping();

            PingOptions pingoptions = new PingOptions
            {
                DontFragment = true
            };

            string data = "aaaaaaaaaaaaaaaa";
            int timeout = 500;
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            int pingsLost = 0;

            foreach (Button item in TestButtons)
            {
                item.Enabled = false;
            }
            resetAVG.Enabled = false;

            for (int i = 0; i < 12; i++)
            {
                await Task.Delay(500);
                PingReply reply = ping.Send(serverURL, timeout, buffer, pingoptions);

                if (reply.Status == IPStatus.Success)
                {
                    long currentPing = reply.RoundtripTime;

                    TenPingsIcons[i].Visible = true;
                    TenPingIterations++;
                    totalTenPing += Convert.ToInt16(currentPing);

                    tenPing.Text = currentPing.ToString("0") + "ms";

                    averageTenPing = totalTenPing / TenPingIterations;

                    tenPingAvg.Text = averageTenPing.ToString("0") + "ms";

                    if (currentPing > maxTenPing)
                    {
                        maxTenPing = currentPing;

                        tenPingHigh.Text = maxTenPing.ToString("0") + "ms";
                    }
                }
                else
                {
                    pingsLost++;
                }
            }

            float loss = ((12 - (float)TenPingIterations) / 12 * 100);

            tenPingsLoss.Text = loss.ToString("0") + "%";

            TenPingIterations = 0;
            totalTenPing = 0;

            foreach (Button item in TestButtons)
            {
                item.Enabled = true;
            }
            resetAVG.Enabled = true;
        }

        private void resetAVG_Click(object sender, EventArgs e) => ResetPings();

        private void ResetPings()
        {
            averageQuickPing = 0;
            averageTenPing = 0;

            QuickPingIterations = 0;
            TenPingIterations = 0;

            totalQuickPing = 0;
            totalTenPing = 0;

            maxQuickPing = 0;
            maxTenPing = 0;

            quiPingHigh.Text = "N/A";
            tenPingHigh.Text = "N/A";

            quiPing.Text = "N/A";
            tenPing.Text = "N/A";

            quiPingAvg.Text = "N/A";
            tenPingAvg.Text = "N/A";

            tenPingsLoss.Text = "N/A";

            foreach (PictureBox item in TenPingsIcons)
            {
                item.Visible = false;
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hover over buttons to get a brief description of their functionalities.\n\n\n\n" +
                "- Syntax:\n\n\nPing - the time required for a packet consisting of 32, 64 or 128 bytes to be sent to the selected server and return with a response\n\n" +
                "Avg - average ping among multiple tests\n\nHigh - highest ping recorded in the current session\n\nLoss - the percentage of 32, 64 or 128 byte packets that were sent to the selected server and a response was never received\n\n" +
                "ms - milliseconds\n\n* in front of a ping value - last packet was either lost or conjointed with the previous one\n\n" +
                "" +
                "Green boxes - each one represents a 32-128 byte packet that's sent to the selected server; if a spot remains empty it means that a packet was lost");
        }

        private void SmallByteButton_Click(object sender, EventArgs e)
        {
            pingString = ttBytes;
            Button btn = (Button)sender;

            btn.Enabled = false;
            BigByteButton.Enabled = true;

            byteCount.Text = "32 bytes";
        }

        private void BigByteButton_Click(object sender, EventArgs e)
        {
            pingString = sfBytes;
            Button btn = (Button)sender;

            btn.Enabled = false;
            SmallByteButton.Enabled = true;
            BiggestByteButton.Enabled = true;

            byteCount.Text = "64 bytes";
        }

        private void BiggestByteButton_Click(object sender, EventArgs e)
        {
            pingString = sfBytes;
            Button btn = (Button)sender;

            btn.Enabled = false;
            BigByteButton.Enabled = true;
            SmallByteButton.Enabled = true;

            byteCount.Text = "128 bytes";
        }
    }
}
