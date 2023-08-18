using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindCPUSerial
{
    public partial class CPUSeriNo : Form
    {
        public CPUSeriNo()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_seribul_Click(object sender, EventArgs e)
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();
            foreach (ManagementObject obj in mObject)
                processorID = obj["ProcessorId"].ToString();

            tb_serino.Text = processorID;
        }
    }
}
