# Parking Lot System (C# OOP)

A simple object-oriented parking lot simulation built in C#.  
The project demonstrates core OOP concepts such as encapsulation, inheritance, class responsibilities, and interaction between objects.

## Overview

This system models a parking lot where vehicles can park in compatible spots and be removed using their license plate.

The goal of the project is to practice designing small systems using object-oriented programming principles rather than focusing only on syntax.

## Features

- Park vehicles in available spots
- Remove vehicles by license plate
- Spot compatibility based on vehicle type
- Encapsulation of parking spot state
- Vehicle hierarchy using inheritance

## System Design

### Vehicle (Abstract Class)
Base class representing a vehicle.

Derived classes:
- `Car`
- `Bike`
- `Truck`

Each vehicle contains:
- License plate
- Model
- Vehicle type

### ParkingSpot

Represents a single parking space in the lot.

Responsibilities:
- Stores the parked vehicle
- Checks if a vehicle can fit in the spot
- Assigns a vehicle to the spot
- Frees the spot when a vehicle leaves

Key methods:
- `CanFit(Vehicle vehicle)`
- `Assign(Vehicle vehicle)`
- `FreeSpot()`

### ParkingLot

Represents the entire parking lot and manages all parking spots.

Responsibilities:
- Maintains a list of parking spots
- Finds available spots for vehicles
- Searches and removes vehicles by license plate

Key methods:
- `ParkVehicle(Vehicle vehicle)`
- `RemoveVehicleByLicensePlate(string licensePlate)`

## Example Flow

1. A vehicle attempts to park.
2. The parking lot searches for a compatible empty spot.
3. If a spot is found, the vehicle is assigned to it.
4. Vehicles can later be removed using their license plate.

## Concepts Demonstrated

- Object-oriented design
- Encapsulation
- Inheritance
- Collections (`List<T>`)
- Iteration and search logic
- Responsibility separation between classes

## Possible Improvements

Future enhancements could include:

- Using enums instead of strings for vehicle types
- Returning the assigned parking spot when parking a vehicle
- Supporting multiple floors
- More advanced spot compatibility rules
- Tracking parking history

## Purpose

This project was created as a learning exercise to strengthen understanding of object-oriented design and system modeling in C#.
