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

* Constructors

* Object Initializer

* Methods

* Access Modifiers

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

We start with the type of the class, give it an identifier and a new operator along with the name of the class to initialize an instance of that class.

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
var report = new Report();

report.Send();
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

#### Section Tutorial:


## Constructors

A constructor is a method that is called when an instance of a class is created.

### Why?

A constructor puts an object into an earlier state.

### How?
```
public class Customer
{
  public Customer()
  {
  }

}
```

Constructors do not have a return type.

Constructor initializes fields of the class to the default values.

```
int = 0
bool = false;
string = null;
object = null
```

Ex:

In this example we have another constructor. with a parameter. we get the name of the customer and we have a name field.

Note the use of the *this* keyword.
```
public class Customer
{
  public string Name;

  public Customer(string name)
  {
    this.Name = name;
  }

}

```
## Object Initializer


## Access Modifiers

In C# we have 5 Access Modifiers.

* Public
* Private
* Protected
* Internal
* Protected Internal

A way to control access to class or its members.

Ex:

Here, we cannot access the **Name** field outside of the scope because the **Name** field is set to *private*.

```
public class Customer
{
  private string Name;
}

var john = new Customer();
John.Name; //won't compile
```

## Object Oriented Programming

* Encapsulation/Information Hiding

* Inheritance

* Polymorphism

### Encapsulation (in practice)

* Define fields as private

* Provide getter/setter method as public

Ex:


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
