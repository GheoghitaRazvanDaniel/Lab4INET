using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    interface IDeviceFinder
    {
        public abstract string FindDevice(DeviceModel model);
        protected static string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }
}
