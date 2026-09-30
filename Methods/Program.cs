// Top-level statements: the program starts here
CreateMenu();

void CreateMenu()
{
    string choice;

    do
    {
        try
        {
            // Construct the menu
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Add Numbers");
            Console.WriteLine("3. Rectangle Area");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            // Accept user input
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SayHello();
                    break;
                case "2":
                    AddNumbers();
                    break;
                case "3":
                    RectangleArea();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            choice = "";   // keep the loop going after an error
        }
    } while (choice != "4");
}

static void SayHello()
{
    Console.WriteLine("Hello, World!");
}

static void AddNumbers()
{
    Console.Write("Enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}

static void RectangleArea()
{
    Console.Write("Please enter rectangle length: ");
    double length = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter rectangle width: ");
    double width = Convert.ToDouble(Console.ReadLine());

    // Calling the method and storing the result
    double area = CalculateArea(length, width);

    Console.WriteLine($"The area of the rectangle is: {area}");
}

// Method declaration
// 'CalculateArea' is the method name
// 'double' is the return type
// 'double length, double width' are the parameters
static double CalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}