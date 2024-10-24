namespace Information_Form
{
    partial class ShopForm
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
            this.lblDeviceSelection = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.grpTechnologies = new System.Windows.Forms.GroupBox();
            this.checkBoxGSM = new System.Windows.Forms.CheckBox();
            this.checkBoxGPRS = new System.Windows.Forms.CheckBox();
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.checkBox4G = new System.Windows.Forms.CheckBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.grpTechnologies.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceSelection
            // 
            this.lblDeviceSelection.AutoSize = true;
            this.lblDeviceSelection.Location = new System.Drawing.Point(20, 20);
            this.lblDeviceSelection.Name = "lblDeviceSelection";
            this.lblDeviceSelection.Size = new System.Drawing.Size(123, 20);
            this.lblDeviceSelection.TabIndex = 0;
            this.lblDeviceSelection.Text = "Select a Device:";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(161, 20);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(200, 28);
            this.deviceComboBox.TabIndex = 1;
            // 
            // grpTechnologies
            // 
            this.grpTechnologies.Controls.Add(this.checkBoxGSM);
            this.grpTechnologies.Controls.Add(this.checkBoxGPRS);
            this.grpTechnologies.Controls.Add(this.checkBoxWiFi);
            this.grpTechnologies.Controls.Add(this.checkBox4G);
            this.grpTechnologies.Location = new System.Drawing.Point(20, 70);
            this.grpTechnologies.Name = "grpTechnologies";
            this.grpTechnologies.Size = new System.Drawing.Size(341, 156);
            this.grpTechnologies.TabIndex = 2;
            this.grpTechnologies.TabStop = false;
            this.grpTechnologies.Text = "Select Technologies";
            // 
            // checkBoxGSM
            // 
            this.checkBoxGSM.AutoSize = true;
            this.checkBoxGSM.Location = new System.Drawing.Point(21, 34);
            this.checkBoxGSM.Name = "checkBoxGSM";
            this.checkBoxGSM.Size = new System.Drawing.Size(72, 24);
            this.checkBoxGSM.TabIndex = 3;
            this.checkBoxGSM.Text = "GSM";
            this.checkBoxGSM.UseVisualStyleBackColor = true;
            // 
            // checkBoxGPRS
            // 
            this.checkBoxGPRS.AutoSize = true;
            this.checkBoxGPRS.Location = new System.Drawing.Point(21, 64);
            this.checkBoxGPRS.Name = "checkBoxGPRS";
            this.checkBoxGPRS.Size = new System.Drawing.Size(81, 24);
            this.checkBoxGPRS.TabIndex = 4;
            this.checkBoxGPRS.Text = "GPRS";
            this.checkBoxGPRS.UseVisualStyleBackColor = true;
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.Location = new System.Drawing.Point(151, 34);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(66, 24);
            this.checkBoxWiFi.TabIndex = 5;
            this.checkBoxWiFi.Text = "WiFi";
            this.checkBoxWiFi.UseVisualStyleBackColor = true;
            // 
            // checkBox4G
            // 
            this.checkBox4G.AutoSize = true;
            this.checkBox4G.Location = new System.Drawing.Point(151, 64);
            this.checkBox4G.Name = "checkBox4G";
            this.checkBox4G.Size = new System.Drawing.Size(57, 24);
            this.checkBox4G.TabIndex = 6;
            this.checkBox4G.Text = "4G";
            this.checkBox4G.UseVisualStyleBackColor = true;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(130, 250);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(100, 40);
            this.btnSimulate.TabIndex = 7;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(416, 20);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(400, 300);
            this.outputTextBox.TabIndex = 8;
            this.outputTextBox.Text = "";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 544);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.grpTechnologies);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.lblDeviceSelection);
            this.Name = "ShopForm";
            this.Text = "Device Shop";
            this.grpTechnologies.ResumeLayout(false);
            this.grpTechnologies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceSelection;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.GroupBox grpTechnologies;
        private System.Windows.Forms.CheckBox checkBoxGSM;
        private System.Windows.Forms.CheckBox checkBoxGPRS;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.CheckBox checkBox4G;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.RichTextBox outputTextBox;
    }
}