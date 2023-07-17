# Hardware Warehouse Management System
This application was created as part of the Advanced C# Tutorial Series created by Gavin Lon on youtube as means to learn about Generics in C#.

# Generics
Generics are like template classes in C++. They allow us to define functions or classes with unspecified type parameters. For example, we can create a function that has a paramters of type "T" where T can be an integer, string or double type. 
Most often we see generics used in collections. For example we can have a list of integers or a list of strings. The benefit of generics is that we can now have compile time type checking which can lead to fewer bugs in code and much fewer 
run time errors. 

In this code example, I used generics to model an inventory system of a warehouse. I created a custom generic Queue class that can take in various hardware items, processes them, and then removes them from the queue. All the data is shown on 
the console window.
