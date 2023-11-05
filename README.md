# Factory Method Pattern

## Overview

The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. It promotes loose coupling and extensibility by separating the client code from the concrete classes it creates.

## Problem

Sometimes, you need to create objects without knowing the exact class of the object you want to create. You want to delegate the responsibility of creating objects to subclasses, and you want to make sure that the appropriate subclass is used to create the object.

## Solution

The Factory Method pattern defines an interface for creating an object, but the specific subclasses decide which class to instantiate. It allows a class to delegate the responsibility of instantiating its objects to its subclasses.

## Key Components

- **Creator:** The abstract class or interface that declares the factory method, which returns an object of type Product.

- **Concrete Creator:** Subclasses of the Creator class that implement the factory method, creating specific instances of Product.

- **Product:** The abstract class or interface that defines the object created by the factory method.

- **Concrete Product:** Subclasses of the Product class, representing specific types of objects created by Concrete Creators.

- **Client:** The code that uses the Creator and Product classes to create and work with objects. It doesn't need to know the specific classes of objects it's creating.

## How to Use

1. Define the Creator (abstract class or interface) with a factory method for creating products.

2. Implement Concrete Creators by subclassing the Creator and providing specific implementations for the factory method.

3. Define the Product (abstract class or interface) that represents the objects created by the factory method.

4. Implement Concrete Products by subclassing the Product to create specific object types.

5. In the client code, work with the Creator and Product classes through their abstract interfaces. Use the factory method to create objects without knowing their specific classes.

## When to Use

Use the Factory Method pattern when:

- A class cannot anticipate the type of objects it must create.
- A class wants its subclasses to specify the objects it creates.
- A class wants to delegate the responsibility of object creation to its subclasses.
- You need to support multiple variations of a product family.

## Purpose

- Promotes loose coupling between client code and concrete classes.
- Allows for extensibility by adding new concrete creators and products without modifying existing code.
- Encourages the use of common interfaces for creating objects, making code more maintainable and understandable.