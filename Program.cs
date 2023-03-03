using System; 

namespace Homework1 {

class Program {
    static void Main(string[] args) {

Console.WriteLine("Input your 6 digit number");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Input your agency abbreviation (CIA/FBI/NSA)");
string agency = Console.ReadLine();

   bool isnumberValid = false;

        switch (agency)
            {
                case "CIA":
                    if (number % 3 == 0 && number / 1000 % 10 >= 6 && number / 1000 % 10 != 8 && number / 10 % 10 != 1 && number / 10 % 10 != 3 && number / 10 % 10 != 5)
                    {
                        isnumberValid = true;
                    }
                    break;

                case "FBI":
                    if (number / 100000 >= 4 && number / 100000 <= 7 && number / 100 % 2 == 0 && number / 100 % 10 != 6 && number / 10000 % 10 % 2 != 0)
                    {
                        isnumberValid = true;
                    }
                    break;

                case "NSA":
                    if (number % 10 == 7 && number % 3 == 0 && number / 100 % 3 == 0 && number / 100 % 2 != 0 && (number / 100000 * number / 10000 * number / 1000 * number / 100 % 10 * number / 10 % 10 * number % 10) % 30 == 0)
                    {
                        isnumberValid = true;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid agency abbreviation.");
                    break;
            }

            if (isnumberValid)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
    
        }
    }
}