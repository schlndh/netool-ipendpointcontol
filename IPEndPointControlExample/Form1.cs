using Netool.Windows.Forms.Controls;
using System;
using System.Windows.Forms;

namespace IPEndPointControlExample
{
    public partial class Form1 : Form
    {
        private bool showLabels = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addrFamilyNone.Checked) ipEndPointControl1.PreferedAddressFamily = IPEndPointControl.PreferedFamily.None;
            else if (addrFamilyIPv4.Checked) ipEndPointControl1.PreferedAddressFamily = IPEndPointControl.PreferedFamily.IPv4;
            else ipEndPointControl1.PreferedAddressFamily = IPEndPointControl.PreferedFamily.IPv6;
            var ep = ipEndPointControl1.EndPoint;
            var str = ep == null ? "NULL" : ep.ToString();
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showLabels = !showLabels;
            ipEndPointControl1.ShowLabels = showLabels;
        }
    }
}