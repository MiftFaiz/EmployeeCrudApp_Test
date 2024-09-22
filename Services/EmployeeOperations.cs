using System;
using System.Collections.Generic;
using EmployeeCrudApp.Models;
using EmployeeCrudApp.Interfaces;

namespace EmployeeCrudApp.Services
{
    public class EmployeeOperations : IEmployeeOperations
    {
        // List untuk menyimpan data karyawan
        private List<Employee> employees = new List<Employee>();

        // Method untuk menambahkan karyawan
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Karyawan {employee.FullName} telah ditambahkan.");
        }

        // Method untuk menampilkan daftar karyawan
        public void DisplayEmployees()
        {
            Console.WriteLine("Employee\n ID\tFullName\tBirthDate");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmployeeID}\t{employee.FullName}\t\t{employee.BirthDate.ToShortDateString()}");
            }
        }

        // Method untuk menghapus karyawan berdasarkan EmployeeID
        public void DeleteEmployee(string employeeId)
        {
            var employee = employees.Find(e => e.EmployeeID == employeeId);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Karyawan {employee.FullName} telah dihapus.");
            }
            else
            {
                Console.WriteLine($"Karyawan dengan ID {employeeId} tidak ditemukan.");
            }
        }
    }
}
