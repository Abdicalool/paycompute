using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee employee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task Delete(int empolyeeId);
        decimal UnionFees(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
        IEnumerable<Employee> GetAll();

    }
}
