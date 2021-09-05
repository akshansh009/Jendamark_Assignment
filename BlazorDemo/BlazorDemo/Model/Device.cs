using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Model
{

    public class Device
    {
        public int DeviceId { get; set; }
        [Required(ErrorMessage = "Device name is required.")]
        public string Name { get; set; }
        public DeviceType DeviceType { get;  set ; }

        public override string ToString()
        {
            return Name;
        }
    }
}
