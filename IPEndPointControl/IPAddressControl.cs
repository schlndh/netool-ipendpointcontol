using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Netool.Windows.Forms
{
    public class IPAddressControl : TextBox
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

        public IPAddress IP
        {
            get
            {
                IPAddress ip;

                if (!IPAddress.TryParse(Text, out ip) && !string.IsNullOrEmpty(Text))
                {
                    var entry = Dns.GetHostEntry(Text);
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
                        // no address is prefered
                        catch (InvalidOperationException)
                        { }
                    }
                }

                return ip;
            }
            set
            {
                if (value == null) Text = "";
                else Text = value.ToString();
            }
        }
    }
}