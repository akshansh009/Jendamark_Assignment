using BlazorDemo.Model;
using BlazorDemo.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Components
{
    public partial class AddDevicesDialog: ComponentBase
    {

        public Device Device
        {
            get;
            set;
        } = new Device { };
        public Devices Devices
        {
            get;
            set;
        } = new Devices { };

        [Inject]
        public IDeviceDataService DeviceDataService
        {
            get;
            set;
        }
        public bool ShowDialog
        {
            get;
            set;
        }
        [Parameter]
        public EventCallback<bool> CloseEventCallback
        {
            get;
            set;
        }
        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        private void ResetDialog()
        {
            Device = new Device { };
        }
        //private CustomValidation
        protected async Task HandleValidSubmit()
        {
            //Operation.Device = new Device { Name = Name };

            await DeviceDataService.AddDevice(Device);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
        protected async Task AddDevice(Device device)
        {
            await DeviceDataService.AddDevice(device);
            StateHasChanged();
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }

    }
}
