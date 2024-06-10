// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
do {
int Num1 = 0;
int Num2 = 0;


Console.WriteLine("-------------------");
Console.WriteLine("Calculator Console App");
Console.WriteLine("-------------------");

Console.WriteLine("Enter First Number And Press Enter");
Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number And Press Enter");
Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Great! Kindly Choose An Option");

Console.WriteLine("\t+ - ADD");
Console.WriteLine("\t- - SUBTRACT");
Console.WriteLine("\t/ - DIVIDE");
Console.WriteLine("\t* - MULTIPLY");

switch (Console.ReadLine())

{

    case "+":

    Console.WriteLine("Your Result {Num1} + {Num2} =" + (Num1 + Num2));
    break;

    case "-":
    Console.WriteLine("Your Result {Num1} - {Num2} =" + (Num1 - Num2));
    break;

    case "/":
    Console.WriteLine("Your Result {Num1} / {Num2} =" + (Num1 / Num2));
    break;

    case "*":
    Console.WriteLine("Your Result {Num1} * {Num2} =" + (Num1 * Num2));
    break;

    


}
    Console.WriteLine("Would you want to continue? (Y=YES, N=NO)");

    }while

   (Console.ReadLine().ToUpper() =="Y");

   Console.WriteLine("Bye!");


 

