namespace Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number.");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operator. +, -, *, or /");
            string Op = Console.ReadLine();

            Console.WriteLine("Choose another number.");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (Op == "+") 
            {
                Console.WriteLine(num1 + num2);
            }
            else if (Op == "-") 
            {
                Console.WriteLine(num1 - num2);
            }
            else if(Op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (Op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}