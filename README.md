# C Sharp Concepts

Covering C# concepts from beginner to advanced.

![csharp photo](http://devstickers.com/assets/img/pro/2p4i.png)

---

## Table of Content
 
### Beginner

### Intermediate

* Classes

* Objects

* Class Members

* Object Oriented Programming


--- 

## Classes

A class can have **fields** and **methods**, which are referred to as **members** of the class. 

Declaring a class
```
public class Report
{

}

```
Declare a field for this class and call it name. The name has an access modifier *public* then the data type of the field *string* and an Identifier

```
public class Report
{
   public string Name;
}
```

Declare a **method** in the class. Start with an access modifier and a signature of the method. A method can have a return type. In this case, void does not have a return value. It has an identifier and in the parenthesis we can put in any parameters for the method.
```
public class Report 
{
  public string Name;
  
  public void Send()
  {
     Console.WriteLine(Name + " is sent.");
  }
}

```

## Objects

Objects are instances of a class.

### Creating Objects Ex:

We start with the type of the class, give it an identifier and a new operator along with the name of the class to initialize an insatance of that class.

```
Report report = new Report();
```

A shorter way to write this code is to use *var* , to save us from typing the full name of the class. 

```
var report = new Report();
```

Now that we have an object, we can access members of that object.

```
var report = new Report();

report.Name = "Top Secret Report";
report.Send();
```
## Class Members

* instance : accessible from an object

```
var person = new Person();

person.Send();
```


* static : accessible from the class

Why use **static** members? To represent concepts that are singleton

ex: DateTime.Now  or Console.WriteLine();

Declaring static members

```
public class Report()
{
  public static int ReportCount = 0;
}
```

## OOP





---

### Advanced

* Generics

* Delegates

* Lambda Expressions

* Events

* Extension Methods

* LINQ

* Nullable Types

* Dynamic 

* Exception Handling

* Asynchronous Programming with Async/ Await

* What's new in C# 6?


---

## Generics 








---

## Additional Resources:

### Courses

### Books

### Tutorials

## Contact: 

* email: marco@marcopineda.com

* twitter: @marcoapineda13


