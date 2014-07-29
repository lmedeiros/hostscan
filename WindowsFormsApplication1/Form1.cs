using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class frmMainScreen : Form
    {
        NetScanner theScanner;
        Int32 proberPort = 135;

        public frmMainScreen()
        {
            InitializeComponent();
            theScanner = new NetScanner();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (theScanner.validate(txtIpAddres.Text))
            {
                try
                {
                    lblStatus.Text = "Scanning...";
                    label3.Visible = true;
                    this.Refresh();
                    theScanner.setIpRange(IPAddress.Parse(txtIpAddres.Text), (int)nupIpAmount.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when setting ip range: " + ex.Message);
                    lblStatus.Text = "Error: " + ex.Message;
                    label3.Visible = false;
                    return;
                }
                
                theScanner.scan();
            }
            else
            {
                MessageBox.Show("No Ip Address Set");
                return;
            }

            lblStatus.Text = "Done!";
            label3.Visible = false;

            lstHosts.Items.Clear();

            if (theScanner.HostList.Count > 0)
            {
                foreach (String[] host in theScanner.HostList)
                {
                    ListViewItem hostItem = new ListViewItem(host);
                    hostItem.ImageIndex = 0;
                    lstHosts.Items.Add(hostItem);
                }
            }
            else
            {
                lstHosts.Items.Add("No hosts found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtIpAddres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstHosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHosts_DoubleClick(object sender, EventArgs e)
        {
            startProbeHost();
        }

        private void startProbeHost()
        {
            if (lstHosts.SelectedIndices.Count > 0)
            {
                try
                {
                    theScanner.theProber = new TcpClient();
                    String host = (string)lstHosts.SelectedItems[0].Text;

                    theScanner.theProber.Connect(IPAddress.Parse(host), proberPort);
                    if (theScanner.theProber.Connected)
                    {
                        MessageBox.Show("Probably is a Windows HOST");
                    }
                    else
                    {
                        MessageBox.Show("Probably is a Linux/Apple HOST");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error probing host: " + ex.Message);
                    theScanner.theProber.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a host!");
                return;
            }
            theScanner.theProber.Close();
        }

        private void nupIpAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
