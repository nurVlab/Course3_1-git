
using OpenHardwareMonitor.Hardware;

namespace Course3_1
{
    using System.Data.Common;
    using System.Runtime.Remoting.Lifetime;
    using System;
    using OpenHardwareMonitor.Hardware;
    using System.Windows.Forms;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Management;
    using OpenHardwareMonitor.Collections;
    using System.Drawing;

    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }
    public class SysInfo
    {
        UpdateVisitor updateVisitor = new UpdateVisitor();
        Computer computer = new Computer();
        public void openComputer() {
            computer.Open();
            computer.CPUEnabled = true;
            computer.RAMEnabled = true;
            computer.GPUEnabled = true;
            computer.MainboardEnabled = true;
           // computer.Accept(updateVisitor);
        }

        public void closeComputer() {
            computer.Close();
        }
        public void computerUpdate() {
            computer.Accept(updateVisitor);
        }
        public Dictionary<string, string> GetSensorDictionary(bool integer, HardwareType hard, SensorType sensor)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == hard) {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == sensor) {
                            if(integer)
                            info.Add(computer.Hardware[i].Sensors[j].Name, ((int?)computer.Hardware[i].Sensors[j].Value).ToString());
                            else info.Add(computer.Hardware[i].Sensors[j].Name, (computer.Hardware[i].Sensors[j].Value).ToString());
                        }
                    }
                }
            }
            return info;
        }
        public float GetSensorValue(HardwareType hard, SensorType sensor)
        {
            float info = new float();
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == hard)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == sensor)
                        {
                            info = (float)computer.Hardware[i].Sensors[j].Value;
                        }
                    }
                }
            }
            return info;
        }

        public string GetSensorString(HardwareType hard, SensorType sensor)
        {
            string info = "";
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == hard)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == sensor)
                        {
                            info = computer.Hardware[i].Sensors[j].Value.ToString();
                        }
                    }
                }
            }
            return info;
        }
        public Dictionary<string, string> GetMotherInfo(bool integer,  SensorType sensor) {

           
            Dictionary<string, string> info = new Dictionary<string, string>();
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.Mainboard)
                {
                    for (int a = 0; a < computer.Hardware[i].SubHardware.Length; a++) {
                        for (int j = 0; j < computer.Hardware[i].SubHardware[a].Sensors.Length; j++)
                        {
                            if (computer.Hardware[i].SubHardware[a].Sensors[j].SensorType == sensor)
                            {
                                if (integer)
                                {
                                    info.Add(computer.Hardware[i].SubHardware[a].Sensors[j].Name, ((int?)(computer.Hardware[i].SubHardware[a].Sensors[j].Value)).ToString());
                                }
                                else
                                    info.Add(computer.Hardware[i].SubHardware[a].Sensors[j].Name, (computer.Hardware[i].SubHardware[a].Sensors[j].Value).ToString());
                            }
                        }
                    }
                }
            }
           
            return info;
        }
        public string GetName(HardwareType hard) {
            string info = "";
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == hard)
                {
                    return computer.Hardware[i].Name;
                }
            }

            return info;
        }
    }
}
