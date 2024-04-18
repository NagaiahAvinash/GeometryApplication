using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using GeometryLibrary; 

class Program
{
    /// <summary>
    /// The main entry point for the Geometry Application, which allows for interactive geometry calculations based on user inputs.
    /// This application utilizes feature management to enable or disable functionality dynamically for computing the area and perimeter of various shapes including squares, rectangles, and triangles.
    /// The application leverages dependency injection to manage services, particularly for feature flags and geometry calculations.
    /// Name: Avinash Nagaiah
    /// Student Id: A00227141
    /// </summary>
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        
        var featureManagement = new Dictionary<string, string>
        {
            {"FeatureManagement:Square", "true"},
            {"FeatureManagement:Rectangle", "true"},
            {"FeatureManagement:Triangle", "true"}
        };

        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        
        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        
        
        var serviceProvider = services.BuildServiceProvider();

        
        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        Console.WriteLine("Welcome to the Geometry Application");
        Console.WriteLine("Please enter dimensions for the shapes as requested.");

       
        double ReadValidDouble(string prompt)
        {
            double input;
            Console.WriteLine(prompt);
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input, please enter a valid number:");
            }
            return input;
        }

        // Check if the Square feature is enabled and prompt for square dimensions
        if (await featureManager.IsEnabledAsync("Square"))
        {
            double side = ReadValidDouble("Enter the side length of the square:");
            var square = new Square(side);
            Console.WriteLine($"Square area: {square.CalculateArea()}");
            Console.WriteLine($"Square perimeter: {square.CalculatePerimeter()}");
        }

        // Check if the Rectangle feature is enabled and prompt for rectangle dimensions
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            double length = ReadValidDouble("Enter the length of the rectangle:");
            double width = ReadValidDouble("Enter the width of the rectangle:");
            var rectangle = new Rectangle(length, width);
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
        }

        // Check if the Triangle feature is enabled and prompt for triangle dimensions
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            double baseLength = ReadValidDouble("Enter the base length of the triangle:");
            double height = ReadValidDouble("Enter the height of the triangle:");
            double sideA = ReadValidDouble("Enter the length of the first side of the triangle:");
            double sideB = ReadValidDouble("Enter the length of the second side of the triangle:");
            double sideC = ReadValidDouble("Enter the length of the third side of the triangle:");
            var triangle = new Triangle(baseLength, height, sideA, sideB, sideC);
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
            Console.WriteLine($"Triangle perimeter: {triangle.CalculatePerimeter()}");
        }
    }
}
