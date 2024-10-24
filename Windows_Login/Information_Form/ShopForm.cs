using Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Form
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            PopulateDeviceComboBox();
        }


        private Devices selectedDevice;

        

        private void PopulateDeviceComboBox()
        {
            // Adding devices to ComboBox
            deviceComboBox.Items.Add("Samsung Galaxy");
            deviceComboBox.Items.Add("LG V60");
            deviceComboBox.Items.Add("iPhone 13");
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            // Clear previous output
            outputTextBox.Clear();

            // Get selected device
            if (deviceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a device.");
                return;
            }

            string selectedDeviceName = deviceComboBox.SelectedItem.ToString();

            // Create instance of the selected device
            switch (selectedDeviceName)
            {
                case "Samsung Galaxy":
                    selectedDevice = new Samsung
                    {
                        DeviceName = "Samsung Galaxy",
                        YearOfProduction = 2021,
                        Color = "Black",
                        SerialNumber = "S123456"
                    };
                    break;
                case "LG V60":
                    selectedDevice = new LG
                    {
                        DeviceName = "LG V60",
                        YearOfProduction = 2020,
                        Color = "Blue",
                        SerialNumber = "L654321"
                    };
                    break;
                case "iPhone 13":
                    selectedDevice = new IPhone
                    {
                        DeviceName = "iPhone 13",
                        YearOfProduction = 2021,
                        Color = "Silver",
                        SerialNumber = "I789012"
                    };
                    break;
            }

            // Check user selections and simulate
            SimulateDeviceUsage();
        }

        private void SimulateDeviceUsage()
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Please select a device.");
                return;
            }

            // GSM
            if (checkBoxGSM.Checked)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " is using GSM.\n");
                selectedDevice.UsingGSM();
            }

            // GPRS (Only for LG and iPhone)
            if (checkBoxGPRS.Checked && selectedDevice is IGPRS gprsDevice)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " is using GPRS.\n");
                gprsDevice.UsingGPRS();
            }
            else if (checkBoxGPRS.Checked)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " does not support GPRS.\n");
            }

            // WiFi (Only for iPhone)
            if (checkBoxWiFi.Checked && selectedDevice is IWifi wifiDevice)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " is using WiFi.\n");
                wifiDevice.UsingWifi();
            }
            else if (checkBoxWiFi.Checked)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " does not support WiFi.\n");
            }

            // 4G (Only for iPhone)
            if (checkBox4G.Checked && selectedDevice is I4G fourGDevice)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " is using 4G.\n");
                fourGDevice.Using4G();
            }
            else if (checkBox4G.Checked)
            {
                outputTextBox.AppendText(selectedDevice.DeviceName + " does not support 4G.\n");
            }
        }
    }
}
