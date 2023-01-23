using Circle_Objects;
bool runProgram = true;
double runCounter = 2;

string value = "";
Console.WriteLine("Welcome to the Circle Tester");

while (runProgram)
{
    double radius = 0;
    while (radius <= 0)
    {
        Console.Write("Enter radius: ");
        while (double.TryParse(Console.ReadLine().Trim(), out radius) == false)
        {
            Console.WriteLine("Not a number, Try again.");
        }
       if (radius< 0)
        {
            Console.WriteLine("Number too low, Try again.");
        }
    }


        Circle myCircle = new Circle(radius)
        {
            Radius = radius
        };

        while (true)
        {
            Console.Write("Continue? (y/n) ");
            string continueCheck = Console.ReadLine().ToLower().Trim();
            if (continueCheck == "y")
            {
                runProgram = true;
                runCounter +=2;
                break;
            }
            else if (continueCheck == "n")
            {
                runProgram = false;
                Console.WriteLine($"Goodbye, you created {runCounter} Circle object(s)");
                break;
            }


        }
}

