In this tutorial we will learn the basic concept of classes and how to use classes.


```
using System;

namespace Classes
{
  public class Person
  {
    public string Name;

    public void Send(string to)
    {
      Console.WriteLine("Hi {0}, I am {1}", to , Name);
    }  
  }

  class Program
  {
    static void Main(string[] args)
    {
      var person = new Person();
      person.Name = "John";
      person.Introduce("Mo");
    }

  }
}

```
