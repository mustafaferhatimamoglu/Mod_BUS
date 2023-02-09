using EasyModbus;
using System.IO.Ports;

namespace Mod_BUS
{


    public partial class Form1 : Form
    {
        private ModbusClient modbusClient = new ModbusClient();

        public string ComPort = "CLEAR";


        public Form1()
        {
            InitializeComponent();


            String[] portNames = SerialPort.GetPortNames();
            foreach (var portName in portNames)
            {
                comboBox1.Items.Add(portName);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ComPort = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {

        }
    }
}