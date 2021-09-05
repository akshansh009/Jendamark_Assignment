using BlazorDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    public interface IOperationDataService
    {
        Task<List<Operation>> GetAllOperations();
        Task AddOperation(Operation operation);
        Task DeleteOperation(Operation operation);
    }
}
