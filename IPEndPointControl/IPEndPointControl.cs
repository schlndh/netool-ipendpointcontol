using System;
using System.Net;
using System.Windows.Forms;

namespace Netool.Windows.Forms
{
    public partial class IPEndPointControl : UserControl
    {
        /// <summary>
        /// Gets or sets prefered address family to return when user enters IP by hostname and DNS resolution returns multiple addresses
        /// </summary>
        public IPAddressControl.PreferedFamily PreferedAddressFamily { get { return ipAddress.PreferedAddressFamily; } set { ipAddress.PreferedAddressFamily = value; } }

        public IPEndPoint EndPoint
        {
            get
            {
                try
                {
                    int port = int.Parse(portText.Text);
                    if (port < 0 || port > 65535)
                    {
                        return null;
                    }
                    var ip = ipAddress.IP;
                    if (ip == null)
                    {
                        return null;
                    }
                    return new IPEndPoint(ip, port);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    ipAddress.IP = null;
                    portText.Text = "";
                }
                else
                {
                    ipAddress.IP = value.Address;
                    portText.Text = value.Port.ToString();
                }
            }
        }

        public string IPLabel { get { return ipLabel.Text; } set { ipLabel.Text = value; } }
        public string PortLabel { get { return portLabel.Text; } set { portLabel.Text = value; } }

        public bool ShowLabels
        {
            get { return tableLayoutPanel1.RowStyles[0].Height > 0; }
            set { tableLayoutPanel1.RowStyles[0].Height = value ? 20 : 0; }
        }

        public IPEndPointControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enables to bypass the EndPoint property and assing hostname to it.
        /// Note: This method doesn't check that given hostname is valid
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="port"></param>
        public void SetEndPointByHostName(string hostname, int port)
        {
            ipAddress.Text = hostname;
            portText.Text = port.ToString();
        }
    }
}