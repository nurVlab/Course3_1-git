using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;

namespace Course3_1
{
   
    public partial class Form1 : Form
    {
        int tCPU, lCPU, lRAM, lGPU;
        Dictionary<string, string> CPUutil,RAMnum,CPUclocks, CPUpowers, GPUclocks, GPUvol,motherVol,
            motherTemp, motherFan, motherControls = new Dictionary<string, string>();
        TreeNode GPUclockTree = new TreeNode("GPU clock");
        TreeNode GPUvolTree = new TreeNode("GPU voltage");
        TreeNode CPUutilTree = new TreeNode("CPU usage");
        TreeNode CPUClockTree = new TreeNode("CPU clock");
        TreeNode CPUpowerTree = new TreeNode("CPU power");
        TreeNode RAMusageTree = new TreeNode("RAM number");
        TreeNode MotherTree = new TreeNode("Motherboard");
        TreeNode MotherVolTree = new TreeNode("Voltages");
        TreeNode MotherTempTree = new TreeNode("Temperature");
        TreeNode MotherFanTree = new TreeNode("Fan");
        TreeNode MotherControlTree = new TreeNode("Fan controls");
        // TreeNode MainTree = new TreeNode();
      
        SysInfo sinfo = new SysInfo();
        UI_tips tp = new UI_tips();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sinfo.closeComputer();
        }

        public Form1()
        {
            string result = "";
            InitializeComponent();
            sinfo.openComputer();
            sinfo.computerUpdate();
           // tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Type" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Name" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "CPU" }, 0, 1);
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                   
                   result = $"{queryObj["Name"]}";
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            tableLayoutPanel1.Controls.Add(new Label() { Text = result }, 1, 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "GPU" }, 0, 2);
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    result = $"{queryObj["Name"]}";
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            tableLayoutPanel1.Controls.Add(new Label() { Text = result }, 1, 2);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Motherboard" }, 0, 3);
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    result = $"{queryObj["Product"]}" + $"{queryObj["Product"]}";
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            tableLayoutPanel1.Controls.Add(new Label() { Text = result }, 1, 3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         updTimer.Enabled = true;
           
        }

        private void UPDtick(object sender, EventArgs e)
        {
            sinfo.computerUpdate();
            tCPU = (int)sinfo.GetSensorValue(HardwareType.CPU, SensorType.Temperature);
            lCPU = (int)sinfo.GetSensorValue(HardwareType.CPU, SensorType.Load);
            lRAM = (int)sinfo.GetSensorValue(HardwareType.RAM, SensorType.Load);
            lGPU = (int)sinfo.GetSensorValue(HardwareType.GpuAti, SensorType.Load);
            tCPU_label.Text = tCPU.ToString()+"℃";
            CPUload_label.Text = lCPU.ToString()+"%";
            RAMload_label.Text = lRAM.ToString()+ "%";
            GPU_load_label.Text = lGPU.ToString() + "%";
            progressBar1.Value = tCPU;
            progressBar2.Value = lRAM;
            progressBar3.Value = lCPU;
            progressBar4.Value = lGPU;
            CPUutil = sinfo.GetSensorDictionary(true, HardwareType.CPU, SensorType.Load);
            RAMnum = sinfo.GetSensorDictionary(false, HardwareType.RAM, SensorType.Data);
            CPUclocks = sinfo.GetSensorDictionary(true, HardwareType.CPU, SensorType.Clock);
            CPUpowers = sinfo.GetSensorDictionary(false, HardwareType.CPU, SensorType.Power);
            if (CPUtree.Nodes.Count != 0)
            {
                tp.updateTree(CPUutilTree, CPUutil, false, " %");
                tp.updateTree(CPUpowerTree, CPUpowers, false, " Watt");
                tp.updateTree(CPUClockTree, CPUclocks, false, " mHz");
            }
            else {
                foreach (KeyValuePair<string, string> par in CPUutil)
                {
                    CPUutilTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " %"));

                }
                CPUtree.Nodes.Add(CPUutilTree);
                CPUClockTree.Nodes.Clear();
                foreach (KeyValuePair<string, string> par in CPUclocks)
                {
                    CPUClockTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " mHz"));

                }
                CPUtree.Nodes.Add(CPUClockTree);
                CPUpowerTree.Nodes.Clear();
                foreach (KeyValuePair<string, string> par in CPUpowers)
                {
                    CPUpowerTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " Watt"));

                }
                CPUtree.Nodes.Add(CPUpowerTree);
                CPUtree.ExpandAll();
            }
            int total = 0;
            if (RAMusageTree.Nodes.Count != 0)
            {
                tp.updateTree(RAMusageTree, RAMnum, true, " MB");
            }
            else
            {
                foreach (KeyValuePair<string, string> par in RAMnum)
                {
                     int val = (int)(float.Parse(par.Value) * 1024);
                      total += val;
                   
                     RAMusageTree.Nodes.Add(new TreeNode(par.Key + ": " + val + " MB"));

                }
                RAMusageTree.Nodes.Add(new TreeNode("Total memory: " + total + " MB"));
                RAMtree.Nodes.Add(RAMusageTree);
                RAMtree.ExpandAll();
            }
            
            GPUclocks = sinfo.GetSensorDictionary(false, HardwareType.GpuAti, SensorType.Clock);
            GPUvol = sinfo.GetSensorDictionary(false, HardwareType.GpuAti, SensorType.Voltage);
            if (GPUtree.Nodes.Count != 0)
            {
                tp.updateTree(GPUclockTree, GPUclocks, false, " mHz");
                tp.updateTree(GPUvolTree, GPUvol, false, " V");
            }
            else {
                foreach (KeyValuePair<string, string> par in GPUclocks)
                {
                    GPUclockTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " mHz"));

                }
                GPUvolTree.Nodes.Clear();
                foreach (KeyValuePair<string, string> par in GPUvol)
                {
                    GPUvolTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " V"));

                }
                GPUtree.Nodes.Add(GPUclockTree);
                GPUtree.Nodes.Add(GPUvolTree);
                GPUtree.ExpandAll();
            }
            motherVol = sinfo.GetMotherInfo(false, SensorType.Voltage);
            motherTemp = sinfo.GetMotherInfo(false, SensorType.Temperature);
            motherFan = sinfo.GetMotherInfo(true, SensorType.Fan);
            motherControls = sinfo.GetMotherInfo(true, SensorType.Control);
            if (MotherTree.Nodes.Count != 0) {
                tp.updateTree(MotherFanTree, motherFan, false, " RPM");
                tp.updateTree(MotherControlTree, motherControls, false, " %");
                tp.updateTree(MotherTempTree, motherTemp, false, " ℃");
                tp.updateTree(MotherVolTree, motherVol, false, " V");
            }
            else {
                foreach (KeyValuePair<string, string> par in motherVol)
                {
                    MotherVolTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " V"));

                }
                foreach (KeyValuePair<string, string> par in motherTemp)
                {
                    MotherTempTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " ℃"));

                }
                foreach (KeyValuePair<string, string> par in motherFan)
                {
                    MotherFanTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " RPM"));

                }
                foreach (KeyValuePair<string, string> par in motherControls)
                {
                    MotherControlTree.Nodes.Add(new TreeNode(par.Key + ": " + par.Value + " %"));
                }
                MotherTree.Text = "Motherboard";
                MotherTree.Nodes.Add(MotherVolTree);
                MotherTree.Nodes.Add(MotherTempTree);
                MotherTree.Nodes.Add(MotherFanTree);
                MotherTree.Nodes.Add(MotherControlTree);
                OveralTree.Nodes.Add(MotherTree);
                OveralTree.ExpandAll();
            }
            
        }

      
    }
}
