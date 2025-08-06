# Parking System in C# 🚗🖊️

### This is a first project to train skills in C# and .NOT! It's basically a management parking program which is possible ```Add```, ```Remove``` and ```List``` vehicles by their license plates.

The system basically contain a logic programing and built-ins from .NET to make everything work ok.


## Clearing pieces of the code 💡
1- Declaring lists   

```private List<string> vehicles = new List<string>();```

```private List<DateTime> time_added = new List<DateTime>();```
Hehe I basically create a list to store vehicles license plates and a nother list to store the time that the vehicle was parked. This time will be associated to vehicle later.

2- Manupulating list in **Remove vehicle**   
```int index_vehicle = vehicles.IndexOf(licensePlate);```
Here I declare a variable called index_vehicle which is gonna receive the index vehicle that is to be removed.

```vehicles.Remove(licensePlate);```
Then the program removed the vehicle.

```time_added.Remove(time_added[index_vehicle]);```
Only when the program take vehicle index and vehicle is removed, this line take the element associated to vehicle index and remove it.


