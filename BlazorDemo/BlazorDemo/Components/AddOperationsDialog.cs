using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Model;
using BlazorDemo.Service;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Components
{
    public partial class AddOperationsDialog : ComponentBase
    {
        public Operation Operation
        {
            get;
            set;
        } = new Operation {Device= new Device {Name= "" } };

        [Inject]
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

        [Parameter]
        public string Name
        {
            get;
            set;
        }
        [Parameter]
        public string DeviceId
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
            Operation = new Operation { };
        }
        
        protected async Task HandleValidSubmit()
        {
            Operation.Device = new Device { Name = Name};

            await OperationDataService.AddOperation(Operation);
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
         
        protected async Task AddOperation(Operation operation)
        {
            await OperationDataService.AddOperation(operation);
            StateHasChanged();
            ShowDialog = false;
            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
