using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Netool.Windows.Forms.Controls
{
    public partial class IPEndPointControl : UserControl
    {
        public enum PreferedFamily
        {
            None, IPv4, IPv6
        }

        private PreferedFamily preferedFamily;

        /// <summary>
        /// Gets or sets prefered address family to return when user enters IP by hostname and DNS resolution returns multiple addresses
        /// </summary>
        public PreferedFamily PreferedAddressFamily { get { return preferedFamily; } set { preferedFamily = value; } }

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
                    IPAddress ip;

                    if (!IPAddress.TryParse(ipText.Text, out ip) && !string.IsNullOrEmpty(ipText.Text))
                    {
                        var entry = Dns.GetHostEntry(ipText.Text);
                        if (entry.AddressList.Length == 0)
                        {
                            return null;
                        }

                        ip = entry.AddressList[0];
                        if (entry.AddressList.Length > 1 && preferedFamily != PreferedFamily.None)
                        {
                            try
                            {
                                ip = entry.AddressList.First(addr =>
                                (addr.AddressFamily == AddressFamily.InterNetwork && preferedFamily == PreferedFamily.IPv4)
                                || (addr.AddressFamily == AddressFamily.InterNetworkV6 && preferedFamily == PreferedFamily.IPv6));
                            }
                            // no element is prefered
                            catch (InvalidOperationException)
                            { }
                        }
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
                    ipText.Text = "";
                    portText.Text = "";
                }
                else
                {
                    ipText.Text = value.Address.ToString();
                    portText.Text = value.Port.ToString();
                }
            }
        }

        public string IPLabel { get { return ipLabel.Text; } set { ipLabel.Text = value; } }
        public string PortLabel { get { return portLabel.Text; } set { portLabel.Text = value; } }

        public bool ShowLabels
        {
            get { return tableLayoutPanel1.RowStyles[0].Height > 0; }
            set
            {
                tableLayoutPanel1.RowStyles[0].Height = value ? 20 : 0;
            }
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
            ipText.Text = hostname;
            portText.Text = port.ToString();
        }
    }
}