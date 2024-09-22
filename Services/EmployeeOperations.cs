using System;
using System.Collections.Generic;
using EmployeeCrudApp.Models;
using EmployeeCrudApp.Interfaces;

namespace EmployeeCrudApp.Services
{
    public class EmployeeOperations : IEmployeeOperations
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            try
            {
                // Validasi tanggal lahir
                if (employee.BirthDate > DateTime.Now)
                {
                    throw new ArgumentException("Tanggal lahir tidak bisa di masa depan.");
                }

                // Cek duplikat berdasarkan EmployeeID
                if (employees.Exists(e => e.EmployeeID == employee.EmployeeID))
                {
                    throw new InvalidOperationException($"Karyawan dengan ID {employee.EmployeeID} sudah ada.");
                }

                employees.Add(employee);
                Console.WriteLine($"Karyawan {employee.FullName} telah ditambahkan.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Employee\n ID\tFullName\tBirthDate");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmployeeID}\t{employee.FullName}\t\t{employee.BirthDate.ToShortDateString()}");
            }
        }

        public void DeleteEmployee(string employeeId)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}
