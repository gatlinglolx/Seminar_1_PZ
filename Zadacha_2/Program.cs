Console.WriteLine("Enter number1");
int number1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2 = Convert.ToInt16(Console.ReadLine());
if (number1 > number2) 
{
    Console.Write("max=");
    System.Console.WriteLine (number1);
}    
if (number2 > number1) 
{
    Console.Write("max=");
    System.Console.WriteLine (number2);
}    
if (number1 == number2) Console.WriteLine("Числа одинаковые");

