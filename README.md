# Calculator

# Description

This is a WPF-based calculator application developed in C#, similar to the Windows Calculator in Standard Mode with some features from Programmer Mode. The application allows users to perform basic arithmetic operations and store values in memory. However, it does not support operator precedence, meaning operations are executed sequentially as they are entered.

# Features

Basic arithmetic operations: Addition (+), Subtraction (-), Multiplication (*), Division (/), Modulus (%), Square Root, Square (x²), Reciprocal (1/x), and Sign Toggle (+/-).

Memory functions:

MC (Memory Clear)

M+ (Add to Memory)

M- (Subtract from Memory)

MR (Memory Recall)

MS (Memory Store)

M> (View memory stack)

# Undo operations:

Backspace (Deletes the last entered digit)

CE (Clears the last entered number)

C (Clears the entire calculation)

Digit Grouping: Numbers are formatted according to the system's locale (e.g., 1,000 for US/UK, 1.000 for Romanian settings).

Programmer Mode: Supports base conversions (Binary, Octal, Decimal, Hexadecimal).

Cut, Copy, and Paste: Implemented manually without relying on built-in text control features.

Keyboard and Mouse Input: Users can input numbers and operations using both keyboard and mouse.

# Persistent Settings: The application remembers:

Last used mode (Standard or Programmer)

Last selected number base (for Programmer Mode)

Digit Grouping setting

Help Menu: Includes an About section displaying developer details.

Non-resizable Window: The application maintains a fixed size.

# Limitations

No Operator Precedence: Operations are executed in the order they are entered (e.g., 1 + 5 * 2 = 12, not 11).

# Technologies Used
C#

WPF (Windows Presentation Foundation)

# Programmer Mode

![image](https://github.com/user-attachments/assets/2c1a3634-4856-4fad-ae12-3d0556dcac40)

# Standard Mode

![image](https://github.com/user-attachments/assets/8cd2eac7-262e-42a1-8201-6dc0085f688b)

