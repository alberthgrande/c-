public class Car
{
    private int _year;

    public string? Model { get; set; }
    public string? Color { get; set; }
    public int Year
    {
        get => _year;
        set
        {
            if (value < 1886)
                throw new ArgumentException("Year must be 1886 or later.");
            _year = value;
        }
    }

    public Car(string model, string color, int year)
    {
        Model = model;
        Color = color;
        Year = year;
    }

    public void FullThrottle()
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    public override string ToString()
    {
        return $"{Year} - {Color} - {Model}";
    }
}

// class Car
// {

// public Car()
// {
//     Model = "Unknown";
//     Color = "Unknown";
//     Year = 1886;
// }

//     private string color = "Red";

//     public string Color
//     {
//         get { return color; }
//         set
//         {
//             Console.WriteLine("Color changed!");
//             color = value;
//         }
//     }
// }
