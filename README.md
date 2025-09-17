# Solid-and-CleanCode-Forms

## Overview

**Solid-and-CleanCode-Forms** is a Windows Forms desktop application built with C# (.NET Framework 4.7.2) for managing teachers, calculating salary increases, and displaying data in an intuitive interface. The project demonstrates the use of SOLID principles and Clean Code practices, making it a great example for learning and applying software design patterns in real-world scenarios.

---

## Features

- **Add Teachers:** Register teachers with different experience levels.
- **Salary Calculation:** Automatically calculate salary increases based on years of service.
- **Data Visualization:** View teacher information and salary adjustments in a dynamic grid.
- **User-Friendly Workflow:** Simple navigation with clear buttons for each action.
- **SOLID & Clean Code:** The codebase is organized using SOLID principles and Clean Code guidelines for maintainability and scalability.

---

## Screenshots

> ![Image](https://github.com/user-attachments/assets/41cf8993-58d1-42da-a7bf-f8df0ff3a43f)

>![Image](https://github.com/user-attachments/assets/0d90098b-3c9e-47a4-8de1-031e665525b6)
> 
> ![Image](https://github.com/user-attachments/assets/5cc6bf56-e84f-4363-b343-862d7b1d2e26)

---

## Technologies Used

- **C# 7.3**
- **.NET Framework 4.7.2**
- **Windows Forms**

---

## Getting Started

1. **Clone the repository:**
    https://github.com/RaulHMV/Solid-and-CleanCode-Forms.git
2. **Open the solution in Visual Studio 2022.**
3. **Build and run the project.**

---

## Usage

1. Enter the teacher’s name and salary.
2. Select the teacher type (by years of experience).
3. Click to add the teacher and view the calculated salary increase.
4. Use the print and return buttons to manage the workflow.

---

## Code Structure

- `Form1.cs`: Main form logic and UI event handling.
- `Profesor.cs`: Abstract base class for teachers.
- `ProfesorNormal`, `Profesor1a10`, `ProfesorMas10`: Concrete teacher types.
- `IProfesorRepository`, `ProfesorRepository`: Repository pattern for managing teacher data.

---

## Contributing

Contributions are welcome! Please follow SOLID and Clean Code principles when submitting changes. Feel free to open issues or pull requests.

---

## Author

Developed by [RaulHMV](https://github.com/RaulHMV).
