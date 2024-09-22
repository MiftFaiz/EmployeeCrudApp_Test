# Employee CRUD Application

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Folder Structure](#folder-structure)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Author](#author)

## Introduction

**Employee CRUD Application** is a simple .NET Core console application that demonstrates basic in-memory Create, Read, and Delete (CRUD) operations for managing employee data. This application allows you to add, display, and delete employees from a list, using an object-oriented design and modular architecture to ensure clean and maintainable code.

## Features
- Add new employees with their ID, full name, and birth date.
- Display a list of all employees.
- Delete employees by their ID.
- In-memory storage, meaning data is not saved after the application exits.

## Folder Structure
The project follows a modular structure, separating responsibilities for clarity and maintainability:

```
EmployeeCrudApp/
├── Interfaces/            # Contains interface definitions
│   └── IEmployeeOperations.cs
├── Models/                # Contains data models
│   └── Employee.cs
├── Services/              # Contains service classes with business logic
│   └── EmployeeOperations.cs
└── Program.cs             # Entry point of the application
```

## Requirements
- **.NET Core SDK**: Make sure you have .NET Core installed. You can check by running:
  ```bash
  dotnet --version
  ```
  If not installed, download it [here](https://dotnet.microsoft.com/download/dotnet-core).

## Installation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/MiftFaiz/EmployeeCrudApp_Test.git
   ```

2. Navigate to the project directory:
   ```bash
   cd EmployeeCrudApp_Test
   ```

3. Restore dependencies and build the project:
   ```bash
   dotnet restore
   dotnet build
   ```

## Usage

1. Run the application:
   ```bash
   dotnet run
   ```

2. Follow the prompts to perform CRUD operations on employee data. You can:
   - Add new employees
   - Display a list of employees
   - Delete employees by their Employee ID

Example:
```bash
dotnet run
```
You'll be able to interact with the application by entering employee information and seeing the list of employees.

## Author

👋 Hello, my name is **Miftah Faiz Hartanto**, and I am a software developer with a strong interest in backend development, system architecture, and RESTful API design. I have experience in various programming languages and frameworks, and I love learning new technologies.

### Skills:
- **Tools & Frameworks**: Git, Postman API Platform, Laravel, CodeIgniter (CI), Springboot, Flask, Vue.js, Express.js, Django REST Framework, .NET
- **Programming Languages**: C++, JSON, PHP, Go, HTML, CSS, JavaScript, Dart, Java, Python
- **Databases**: MySQL, PostgreSQL, MongoDB, Navicat

Feel free to check out more of my work or reach out if you'd like to connect!

- **Email**: miftah.faiz.h@gmail.com
- **GitHub**: [MiftFaiz](https://github.com/MiftFaiz)


If you have any questions or suggestions for this project, don't hesitate to reach out!
