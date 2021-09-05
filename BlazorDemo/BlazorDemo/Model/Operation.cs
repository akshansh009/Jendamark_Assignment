using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Model
{
    public class Operation
    {
        public int operationId { get; set; }
        [Required(ErrorMessage ="Operation name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Order of execution is required.")]
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public Device Device { get; set; }
    }
}
