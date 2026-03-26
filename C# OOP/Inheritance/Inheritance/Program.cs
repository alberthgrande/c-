using Inheritance;

// Create a myCar object
Car myCar = new Car();

// Call the honk() method (From the Vehicle class) on the myCar object
myCar.honk();

// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
Console.WriteLine($"{myCar.brand} {myCar.modelName}");