# PasswordValidation

Sample solution providing a simple password validator with tests.

## Pre-requisites

- git
- dotnet core

## Setup

Clone the repository

```
git clone git@github.com:stormwild/PasswordValidation.git
cd PasswordValidation
```

Run the tests

```
dotnet test
```

Sample output:

```
Microsoft (R) Test Execution Command Line Tool Version 15.9.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 5. Passed: 5. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.3351 Seconds
```

## Changelog

2019-05-25 - Added validator using local functions

## Local Functions

> Starting with C# 7.0, C# supports local functions. Local functions are private methods of a type that are nested in another member. They can only be called from their containing member. Local functions can be declared in and called from:
> 
> - Methods, especially iterator methods and async methods
> - Constructors
> - Property accessors
> - Event accessors
> - Anonymous methods
> - Lambda expressions
> - Finalizers
> - Other local functions
>
> However, local functions can't be declared inside an expression-bodied member.

> ```csharp
> using System;
> using System.IO;
> 
> class Example
> {
>     static void Main()
>     {
>         string contents = GetText(@"C:\temp", "example.txt");
>         Console.WriteLine("Contents of the file:\n" + contents);
>     }
>    
>     private static string GetText(string path, string filename)
>     {
>          var sr = File.OpenText(AppendPathSeparator(path) + filename);
>          var text = sr.ReadToEnd();
>          return text;
>          
>          // Declare a local function.
>          string AppendPathSeparator(string filepath)
>          {
>             if (! filepath.EndsWith(@"\"))
>                filepath += @"\";
> 
>             return filepath;   
>          }
>     } 
> }
> ```

## Expression-bodied members

> Expression body definitions let you provide a member's implementation in a very concise, readable form. You can use an expression > body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. An > expression body definition has the following general syntax:
> 
> ```csharp
> member => expression;
> ```
> 
> An expression-bodied method consists of a single expression that returns a value whose type matches the method's return type, or, for methods that return void, that performs some operation. For example, types that override the ToString method typically include a single expression that returns the string representation of the current object.
>
> ```csharp
> using System;
> 
> public class Person
> {
>    public Person(string firstName, string lastName)
>    {
>       fname = firstName;
>       lname = lastName;
>    }
> 
>    private string fname;
>    private string lname;
>    
>    public override string ToString() => $"{fname} {lname}".Trim();
>    public void DisplayName() => Console.WriteLine(ToString());
> }
> 
> class Example
> {
>    static void Main()
>    {
>       Person p = new Person("Mandy", "Dejesus");
>       Console.WriteLine(p);
>       p.DisplayName();
>    }
> }
> ```

## References

- [Local functions (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
- [Expression-bodied members (C# programming guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)



