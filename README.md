# Calculator Application (C# - Windows Forms)

This project is a simple calculator application developed using C# and Windows Forms.  
It provides a graphical user interface (GUI) where users can perform basic arithmetic operations and memory functions.

## Features

-  Basic arithmetic operations (+, -, *, /)
-  Memory functions:
  - M+ (add to memory)
  - M- (subtract from memory)
  - MR (recall memory)
  - MC (clear memory)
-  Sign change (+/-) functionality
-  Button-based input system
-  Dynamic display using TextBox
-  Event-driven interaction model

##  Technologies Used

- C#
- Windows Forms (WinForms)
- .NET Framework

## Project Structure

- `Form1.cs` → Main application logic
- Event Handlers:
  - `btn1_Click` → Handles number input
  - `btnTopla_Click` → Stores operation type
  - `btnEnter_Click` → Executes calculation
  - Memory buttons → Manage stored values

## How It Works

- User enters numbers via button clicks
- Selected operation is stored temporarily
- When "=" is pressed:
  - The operation is executed
  - Result is displayed on the screen
- Memory functions allow storing and reusing values

## How to Run

1. Open the project in Visual Studio  
2. Build the solution  
3. Run the application  

## Future Improvements

- Add error handling (e.g., division by zero)
- Improve UI/UX design
- Add keyboard input support
- Extend with advanced mathematical operations

## Author

Developed as a learning project to practice:
- Event-driven programming
- GUI development with WinForms
- C# fundamentals
