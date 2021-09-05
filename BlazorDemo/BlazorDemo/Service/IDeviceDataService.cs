using BlazorDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    public interface IDeviceDataService
    {
        Task <List<Device>> GetAllDevices();
        Device GetDevice(DeviceType deviceType);
        Task AddDevice(Device Device);
        Task DeleteDevice(Device Device);
    }
}
