using System;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
	class Program
	{
		static void Main(string[] args)
		{
            int result;
            Console.Write("> ");
            Console.WriteLine("Enter the numbers: ");
            string[] input = Console.ReadLine().Split(" ");
            int input1 = int.Parse(input[0]);
            int input2 = int.Parse(input[2]);
            char op = char.Parse(input[1]);
            
            if (op == '+') {
                Console.WriteLine($"> Result:  {input1 + input2}");
                return;
            } else if (op == '-') {
                Console.WriteLine($"> Result:  {input1 - input2}");
                return;
            } else if (op == '*') {
                Console.WriteLine($"> Result:  {input1 * input2}");
            }  else if (op == '/') {
                Console.WriteLine($"> Result:  {input1 / input2}");
            } else {
                Console.WriteLine("ERROR: Operator invalid!");
                return;
            }
		}
	}

}
