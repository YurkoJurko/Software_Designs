# Lab 1 code review

**Coding patterns presented in my project**

## 1. DRY
In this project, I maximized reusability and universality of methods, so I don't have any repeating code.

## 2. KISS
The structure of this project is very simple, with no complex superstructures, and maximizes readability.

## 3. SOLID - Single Responsibility Principle
Each class is responsible for certain functionality without interfering with the work of other classes.

## 4. YAGNI
Each class and method is used in accordance with the Technical Specifications. Methods that are not used or are superfluous are absent.

## 5. Composition Over Inheritance
Instead of inheritance I compose classes, using class objects as fields in bigger classes. 
[Exmaple of composition in Warehouse class](./Lab1/ClassLibrary/Warehouse.cs#L11)

## 6. Fail Fast
I use checks
