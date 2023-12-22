# Car Racing Simulation

## Overview

This project is a simple car racing simulation program written in C# with object-oriented principles. It includes classes for cars, drivers, car manufacturers, and a basic race simulation.

## Table of Contents

- [Classes](#classes)
  - [Car](#car)
  - [CarType](#cartype)
  - [IPerson](#iperson)
  - [Driver](#driver)
  - [CarManufacturer](#carmanufacturer)
  - [Race](#race)
- [Interfaces](#interfaces)
  - [IPrintable](#iprintable)
- [Usage](#usage)
- [How to Run](#how-to-run)
- [Contributing](#contributing)
- [License](#license)

## Classes

### Car

The `Car` class represents a car with properties such as Id, Model, Year, Type, and Owner.

### CarType

The `CarType` enum defines different types of cars, such as Sedan, Coupe, SUV, etc.

### IPerson

The `IPerson` interface defines the properties of a person, including FirstName, LastName, Age, and Nationality.

### Driver

The `Driver` class implements the `IPerson` interface and includes an additional property for Salary.

### CarManufacturer

The `CarManufacturer` class represents a car manufacturer with properties like Name, Founded, and a list of Cars.

### Race

The `Race` class simulates a race between two cars and implements the `IPrintable` interface.

## Interfaces

### IPrintable

The `IPrintable` interface includes a method `PrintToDisplay` to print information to the display.
