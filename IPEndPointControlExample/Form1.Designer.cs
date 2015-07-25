namespace IPEndPointControlExample
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipEndPointControl1 = new Netool.Windows.Forms.Controls.IPEndPointControl();
            this.button1 = new System.Windows.Forms.Button();
            this.addrFamilyNone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addrFamilyIPv6 = new System.Windows.Forms.RadioButton();
            this.addrFamilyIPv4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipEndPointControl1
            // 
            this.ipEndPointControl1.EndPoint = null;
            this.ipEndPointControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipEndPointControl1.IPLabel = "IP";
            this.ipEndPointControl1.Location = new System.Drawing.Point(12, 12);
            this.ipEndPointControl1.Name = "ipEndPointControl1";
            this.ipEndPointControl1.PortLabel = "Port";
            this.ipEndPointControl1.PreferedAddressFamily = Netool.Windows.Forms.Controls.IPEndPointControl.PreferedFamily.None;
            this.ipEndPointControl1.Size = new System.Drawing.Size(239, 49);
            this.ipEndPointControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get EndPoint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addrFamilyNone
            // 
            this.addrFamilyNone.AutoSize = true;
            this.addrFamilyNone.Checked = true;
            this.addrFamilyNone.Location = new System.Drawing.Point(6, 19);
            this.addrFamilyNone.Name = "addrFamilyNone";
            this.addrFamilyNone.Size = new System.Drawing.Size(51, 17);
            this.addrFamilyNone.TabIndex = 2;
            this.addrFamilyNone.TabStop = true;
            this.addrFamilyNone.Text = "None";
            this.addrFamilyNone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addrFamilyIPv6);
            this.groupBox1.Controls.Add(this.addrFamilyIPv4);
            this.groupBox1.Controls.Add(this.addrFamilyNone);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prefered Address Family";
            // 
            // addrFamilyIPv6
            // 
            this.addrFamilyIPv6.AutoSize = true;
            this.addrFamilyIPv6.Location = new System.Drawing.Point(116, 19);
            this.addrFamilyIPv6.Name = "addrFamilyIPv6";
            this.addrFamilyIPv6.Size = new System.Drawing.Size(47, 17);
            this.addrFamilyIPv6.TabIndex = 4;
            this.addrFamilyIPv6.Text = "IPv6";
            this.addrFamilyIPv6.UseVisualStyleBackColor = true;
            // 
            // addrFamilyIPv4
            // 
            this.addrFamilyIPv4.AutoSize = true;
            this.addrFamilyIPv4.Location = new System.Drawing.Point(63, 19);
            this.addrFamilyIPv4.Name = "addrFamilyIPv4";
            this.addrFamilyIPv4.Size = new System.Drawing.Size(47, 17);
            this.addrFamilyIPv4.TabIndex = 3;
            this.addrFamilyIPv4.Text = "IPv4";
            this.addrFamilyIPv4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Toggle Labels";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 173);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipEndPointControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Netool.Windows.Forms.Controls.IPEndPointControl ipEndPointControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton addrFamilyNone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton addrFamilyIPv6;
        private System.Windows.Forms.RadioButton addrFamilyIPv4;
        private System.Windows.Forms.Button button2;
    }
}

