// See https://aka.ms/new-console-template for more information
//Declare variables

int numberOfGuests;
int slicesPerGuest = 3; // Assume each guest eats 3 slices
int slicesPerPizza = 8; // Standard pizza has 8 slices

Console.Write("Enter the number of guests: ");
numberOfGuests = int.Parse(Console.ReadLine());
// Call the Parse function to turn the value the user entered into an int
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculate the number of pizza required
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Output the result to the user
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");

