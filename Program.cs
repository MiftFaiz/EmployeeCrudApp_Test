using System;
using EmployeeCrudApp.Services;
using EmployeeCrudApp.Models;
using EmployeeCrudApp.Interfaces;

namespace EmployeeCrudApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance dari EmployeeOperations
            IEmployeeOperations employeeOperations = new EmployeeOperations();

            // Menambahkan beberapa karyawan secara hardcoded
            employeeOperations.AddEmployee(new Employee { EmployeeID = "1001", FullName = "Adit", BirthDate = new DateTime(2054, 8, 17) });
            employeeOperations.AddEmployee(new Employee { EmployeeID = "1001", FullName = "Adit", BirthDate = new DateTime(1954, 8, 17) });
            employeeOperations.AddEmployee(new Employee { EmployeeID = "1001", FullName = "Adit", BirthDate = new DateTime(1954, 8, 17) });
            employeeOperations.AddEmployee(new Employee { EmployeeID = "1002", FullName = "Anton", BirthDate = new DateTime(1954, 8, 18) });
            employeeOperations.AddEmployee(new Employee { EmployeeID = "1003", FullName = "Amir", BirthDate = new DateTime(1954, 8, 19) });

            // Menampilkan daftar karyawan
            employeeOperations.DisplayEmployees();

            // Menghapus karyawan dengan ID 1001
            employeeOperations.DeleteEmployee("1001");

            // Menampilkan daftar karyawan setelah penghapusan
            employeeOperations.DisplayEmployees();
        }
    }
}
