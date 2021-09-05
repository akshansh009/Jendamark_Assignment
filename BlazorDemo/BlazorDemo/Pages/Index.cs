using BlazorDemo.Components;
using BlazorDemo.Model;
using BlazorDemo.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Pages
{
    public partial class Index
    {
        public IEnumerable<Operation> Operations
        {
            get;
            set;
        }
        public IEnumerable<Device> Devices
        {
            get;
            set;
        }

        [Inject]
        public IOperationDataService OperationDataService
        {
            get;
            set;
        }
        [Inject]
        public IDeviceDataService DeviceDataService
        {
            get;
            set;
        }
        [Inject]
        public AddOperationsDialog AddOperationsDialog
        {
            get;
            set;
        }
        [Inject]
        public AddDevicesDialog AddDevicesDialog
        {
            get;
            set;
        }

        protected override async Task OnInitializedAsync()
        {
            Operations = await OperationDataService.GetAllOperations();
            Devices = await DeviceDataService.GetAllDevices();
        }

        protected async Task DeleteOperation(Operation operation)
        {
            await OperationDataService.DeleteOperation(operation);
            StateHasChanged();
        }
        protected async Task DeleteDevice(Device device)
        {
            await DeviceDataService.DeleteDevice(device);
            StateHasChanged();
        }

        protected void QuickAddOperation()
        {
            AddOperationsDialog.Show();
        }

        protected void QuickAddDevice()
        {
            AddDevicesDialog.Show();
        }

        protected async Task AddOperation(Operation operation)
        {
            await OperationDataService.AddOperation(operation);
            StateHasChanged();
        }

        protected async Task AddDevice(Device device)
        {
            await DeviceDataService.AddDevice(device);
            StateHasChanged();
        }

        public async void AddOperationsDialog_OnDialogClose()
        {
            Operations = await OperationDataService.GetAllOperations();
            StateHasChanged();
        }

        public async void AddDevicesDialog_OnDialogClose()
        {
            Devices = await DeviceDataService.GetAllDevices();
            StateHasChanged();
        }
    }
}
