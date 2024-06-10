do
{
    float num1 = 0;
    float num2 = 0;

    Console.WriteLine("-------------------");
    Console.WriteLine("Calculator Console App");
    Console.WriteLine("-------------------");

    Console.WriteLine("Enter First Number And Press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Second Number And Press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Great! Kindly Choose An Option");

    Console.WriteLine("\t+ - ADD");
    Console.WriteLine("\t- - SUBTRACT");
    Console.WriteLine("\t/ - DIVIDE");
    Console.WriteLine("\t* - MULTIPLY");

    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine("Your Result {num1} + {num2} =" + (num1 + num2));
            break;

        case "-":
            Console.WriteLine("Your Result {num1} - {num2} =" + (num1 - num2));
            break;

        case "/":
            Console.WriteLine("Your Result {num1} / {num2} =" + (num1 / num2));
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non zero Number");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            break;

        case "*":

            Console.WriteLine("Your Result {num1} * {num2} =" + (num1 * num2));
            break;
    }
    Console.WriteLine("Would you want to continue? (Y=YES, N=NO)");

} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Bye!");