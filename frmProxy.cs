using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

using log4net;
using Microsoft.Win32;
using System.Diagnostics;

namespace ProxyDevFeeClaymore
{
    
    public partial class frmProxy : Form
    {

        internal static log4net.ILog Log { get; set; }
        static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        string consoleMsg = "";
       
        bool Started = false;
        string donatebtc = "13bdxNmky97ShCzA3ywZ7zBZiehmk6itLc";
        public frmProxy()
        {
            InitializeComponent();
           
        }
      
        private TcpForwarderSlim proxy;
      
       
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!LogManager.GetRepository().Configured)
            {
                
                log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config"));
            }

            if (chkAutoStart.Checked)
            {
                ChangeStartState();
            }
           
            SetStartUp();
            backgroundWorker1.RunWorkerAsync();
           

        }

     

       

    
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkAutoStart.Checked)
            {
                SetStartUp();
            }
            Properties.Settings.Default.Save();
            
            MessageBox.Show(" Setting Save success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
         void SetStartUp()
        {
           
            
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);               

                key.SetValue("ProxyDevFee", System.Reflection.Assembly.GetEntryAssembly().Location, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
      
        private void ChangeStartState()
        {
          
            if (Started)
            {
                btnStartProxy.BackColor = Color.Green;
                btnStartProxy.Text = "Start Proxy";
                Started = false;
                proxy.Stop();
                proxy = null;
               
                
               
            }
            else
            {
                btnStartProxy.BackColor = Color.Red;
                btnStartProxy.Text = "Stop Proxy";
                Started = true;
                StartProxy();
            }
        }
        void StartProxy()
        {
            string Error = "";
            if (String.IsNullOrEmpty(Properties.Settings.Default.PoolHost))
            {
                Error += "- Pool host is reqiured" + Environment.NewLine;
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.WalletAddress))
            {
                Error += "- My Wallet address is reqiured" + Environment.NewLine;
            }
            if (Error != "")
            {
               
                MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Started = false;
                btnStartProxy.BackColor = Color.Green;
                btnStartProxy.Text = "Start Proxy";
                return;
            }           
            string activity=String.Format("Start proxy connect to {0}:{1}",Properties.Settings.Default.PoolHost,Properties.Settings.Default.PoolPort);
            logger.Info(activity);
            consoleLog.AppendText(activity + Environment.NewLine);
           
          
               try
                  {
                      IPHostEntry hostEntry;
                     
                    
                      proxy = new TcpForwarderSlim();
                      hostEntry = Dns.GetHostEntry(Properties.Settings.Default.PoolHost);
                      proxy.writelog += new TcpForwarderSlim.ConsoleEventMsg(proxy_writelog);
                      proxy.Start(new IPEndPoint(IPAddress.Any, Convert.ToInt32(Properties.Settings.Default.ListenPort)),
                            new IPEndPoint(hostEntry.AddressList[0], Convert.ToInt32(Properties.Settings.Default.PoolPort)), Properties.Settings.Default.WalletAddress, ref consoleMsg);

                  }
                  catch (Exception ex)
                  {
                      ChangeStartState();
                      MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      logger.Error(ex.Message);

                      
                  }
          
        }

        void proxy_writelog(string message)
        {
            if (message != "")
            {
                if (consoleLog.InvokeRequired)
                {
                    consoleLog.Invoke(new MethodInvoker(delegate {
                        consoleLog.AppendText(message + Environment.NewLine);
                        consoleLog.ScrollToCaret();

                    }));
                    
                }
                
            }
        }
        private void btnStartProxy_Click(object sender, EventArgs e)
        {
            ChangeStartState();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtBTCDonate.Text != donatebtc)
            {
                txtBTCDonate.Text = donatebtc;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proxy != null)
            {
                proxy.Stop();
               
                this.Dispose();
            }
        }

        private void btnReadMe_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo("Readme.txt");
            Process p = new Process();
            p.StartInfo = ps;
            p.Start();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBTCDonate.Text);
        }

        private void tmStartProxy_Tick(object sender, EventArgs e)
        {
            tmStartProxy.Stop();
            StartProxy();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.ipify.org?format=json");
            var respon= req.GetResponse();
            var responseString = new StreamReader(respon.GetResponseStream()).ReadToEnd();
            var serializer = new JavaScriptSerializer();
            dynamic ip = serializer.DeserializeObject(responseString);

            e.Result = ip["ip"];
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtMyPublicIP.Text = e.Result.ToString();
        }
    }
}
