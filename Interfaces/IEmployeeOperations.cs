using EmployeeCrudApp.Models;

namespace EmployeeCrudApp.Interfaces
{
    public interface IEmployeeOperations
    {
        void AddEmployee(Employee employee);
        void DisplayEmployees();
        void DeleteEmployee(string employeeId);
    }
}
