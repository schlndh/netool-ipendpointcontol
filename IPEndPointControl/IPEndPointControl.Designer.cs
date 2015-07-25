namespace Netool.Windows.Forms
{
    partial class IPEndPointControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.ipAddress = new Netool.Windows.Forms.IPAddressControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ipLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.portLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.portText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ipAddress, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 101);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipLabel.Location = new System.Drawing.Point(3, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(17, 20);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP";
            this.ipLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.portLabel.Location = new System.Drawing.Point(325, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 20);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // portText
            // 
            this.portText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portText.Location = new System.Drawing.Point(325, 23);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(44, 20);
            this.portText.TabIndex = 1;
            // 
            // ipAddress
            // 
            this.ipAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAddress.IP = null;
            this.ipAddress.Location = new System.Drawing.Point(3, 23);
            this.ipAddress.MaxLength = 255;
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.PreferedAddressFamily = Netool.Windows.Forms.IPAddressControl.PreferedFamily.None;
            this.ipAddress.Size = new System.Drawing.Size(316, 20);
            this.ipAddress.TabIndex = 0;
            // 
            // IPEndPointControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IPEndPointControl";
            this.Size = new System.Drawing.Size(372, 101);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portText;
        private IPAddressControl ipAddress;

    }
}
