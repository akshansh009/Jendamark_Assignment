using BlazorDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    public class DeviceDataService : IDeviceDataService
    {
        private static List<Device> Devices = new List<Device>
        {
            new Device { DeviceId = 1, DeviceType = DeviceType.BarcodeScanner, Name = "Device 1" },
            new Device { DeviceId = 2, DeviceType = DeviceType.Camera, Name = "Device 2" },
            new Device { DeviceId = 3, DeviceType = DeviceType.Printer, Name = "Device 3" },
            new Device { DeviceId = 4, DeviceType = DeviceType.SocketTray, Name = "Device 4" },
        };

        public Task AddDevice(Device Device)
        {
            return Task.Run(() => Devices.Add(Device));
        }

        public Task DeleteDevice(Device Device)
        {
            return Task.Run(() => Devices.Remove(Device));
        }

        public Device GetDevice(DeviceType deviceType)
        {
            return Devices.FirstOrDefault(x => x.DeviceType == deviceType);
        }

        Task<List<Device>> IDeviceDataService.GetAllDevices()
        {
            return Task.Run(() => Devices);
        }
    }
}
