# C# NullReferenceException Example

This repository demonstrates a common C# error: the `NullReferenceException`.  The `bug.cs` file contains code that will throw this exception if the `MyProperty` is not initialized before it is accessed. The solution in `bugSolution.cs` shows how to properly handle the potential null value.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs` (it will throw a `NullReferenceException`).
3. Examine `bugSolution.cs` to see the corrected code.

## Common Causes of NullReferenceExceptions

* **Uninitialized variables:**  Variables that are declared but not initialized before use. 
* **Null return values:** Methods returning null when not expected.
* **Missing error handling:** Lack of checks for null values before accessing members.
* **Incorrect object instantiation:** Issues during the process of creating a new instance of an object.