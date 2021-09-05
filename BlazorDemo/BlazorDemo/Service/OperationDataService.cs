using BlazorDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    public class OperationDataService : IOperationDataService
    {
        private IDeviceDataService _deviceData;
        public OperationDataService(IDeviceDataService deviceData)
        {
            _deviceData = deviceData;
            Operations.Add(new Operation { Device = _deviceData.GetDevice(DeviceType.BarcodeScanner), Name = "Operation 1", operationId = 1, OrderInWhichToPerform = 1 });
            Operations.Add(new Operation { Device = _deviceData.GetDevice(DeviceType.Camera), Name = "Operation 2", operationId = 2, OrderInWhichToPerform = 2 });
            Operations.Add(new Operation { Device = _deviceData.GetDevice(DeviceType.Printer), Name = "Operation 3", operationId = 3, OrderInWhichToPerform = 2 });
            Operations.Add(new Operation { Device = _deviceData.GetDevice(DeviceType.SocketTray), Name = "Operation 4", operationId = 4, OrderInWhichToPerform = 4});
        }

        static List<Operation> Operations = new List<Operation>();
        
        public Task AddOperation(Operation operation)
        {
            return Task.Run(() => { Operations.Add(operation); });
        }

        public Task DeleteOperation(Operation operation)
        {
            return Task.Run(() => { Operations.Remove(operation); });
        }

        public Task<List<Operation>> GetAllOperations()
        {
            return Task<List<Operation>>.Run(() => Operations);
        }
    }
}
