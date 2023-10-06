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
            Console.WriteLine("> Choose a language\n- Type \"ro\" or \"en\"");
            string lang = Console.ReadLine()?.ToLower();
            if (lang == "ro") {
                Console.WriteLine("Introdu numerele: ");
                string[] input = Console.ReadLine().Split(" ");
                int input1 = int.Parse(input[0]);
                int input2 = int.Parse(input[2]);
                char op = char.Parse(input[1]);
                if (op == '+') {
                        Console.WriteLine($"> Rezultat:  {input1 + input2}");
                        return;
                    } else if (op == '-') {
                        Console.WriteLine($"> Rezultat:  {input1 - input2}");
                        return;
                    } else if (op == '*') {
                        Console.WriteLine($"> Rezultat:  {input1 * input2}");
                    }  else if (op == '/') {
                        if (input2 != 0) {
                        Console.WriteLine($"> Rezultat:  {input1 / input2}");
                        } else {
                            Console.Write("EROARE: Nu poti imparti cu 0.");
                        }
                    } else {
                        Console.WriteLine("EROARE: Operator invalid!");
                        return;
                    }
            } else if (lang == "en") {
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
                        if (input2 != 0) {
                        Console.WriteLine($"> Rezultat:  {input1 / input2}");
                        } else {
                            Console.Write("EROARE: Cannot divide by 0.");
                        }
                    } else {
                        Console.WriteLine("ERROR: Invalid operator!");
                        return;
                    }
            } else {
                Console.Write("ERROR: \n[EN] Invalid language!\n[RO] Limba invalida!");
            }

            
            
		}
	}

}
