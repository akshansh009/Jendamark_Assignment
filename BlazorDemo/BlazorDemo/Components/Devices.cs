using BlazorDemo.Model;
using BlazorDemo.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BlazorDemo.Components
{
    public partial class Devices : ComponentBase
    {
        [Parameter]
        public string DeviceId
        {
            get;
            set;
        }
        [Parameter]
        public Device Device
        {
            get;
            set;
        }
        [Parameter]
        public string Name
        {
            get;
            set;
        }
        public List<Device> DeviceMaster
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
        [Parameter]
        public string Value
        {
            get;
            set;
        }
        [Parameter]
        public EventCallback<string> ValueChanged
        {
            get;
            set;
        }
        protected async override Task OnInitializedAsync()
        {
            DeviceMaster = (await DeviceDataService.GetAllDevices());
        }
        private Task OnValueChanged(ChangeEventArgs e)
        {
            Value = e.Value.ToString();
            return ValueChanged.InvokeAsync(Value);
        }

    }
}
