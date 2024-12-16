# Uninitialized Property Access in C#

This repository demonstrates a common error in C# involving accessing a property before it has been assigned a value.  This can lead to unexpected behavior or exceptions.  The `bug.cs` file contains the erroneous code, while `bugSolution.cs` provides a corrected version.

## Problem

In the `MyClass` class, the `MyMethod` attempts to use the `MyProperty` before it's guaranteed to be initialized. This could lead to `MyProperty` having its default value (0 for integers) rather than the expected value, potentially causing calculation errors or exceptions.

## Solution

The solution in `bugSolution.cs` ensures that `MyProperty` is always initialized before it is used, removing the risk of unexpected behavior.