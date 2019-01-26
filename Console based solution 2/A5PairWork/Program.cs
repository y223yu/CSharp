using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation reserve = new Reservation();

            do
            {
                Console.WriteLine("Reservation program Menu:");
                Console.WriteLine("1. Display available seating");
                Console.WriteLine("2. Reserve/add a seat for a custom");
                Console.WriteLine("3. Remove a reservation (by customer name)");
                Console.WriteLine("4. Remove a reservation (by seat number/code)");
                Console.WriteLine("5. Test load (all seats) to capacity");
                Console.WriteLine("6. Exit Menu/End program");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Your chose: ");

                string input = Console.ReadLine();
                int nInput;
                while (int.TryParse(input, out nInput) == false || int.Parse(input) < 1 || int.Parse(input) > 6)
                {
                    Console.Write("Invalid optiton! Please enter again: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out nInput) == true && int.Parse(input) >= 1 && int.Parse(input) <= 6)
                    {
                        break;
                    }
                }
                nInput = int.Parse(input);
                if (nInput == 1)
                {
                    reserve.DisplaySeat();
                }

                else if (nInput == 2)
                {
                    reserve.ReserveSeat();
                }

                else if (nInput == 3)
                {
                    reserve.RemoveByName();
                }

                else if (nInput == 4)
                {
                    reserve.RemoveBySeat();
                }

                else if (nInput == 5)
                {
                    reserve.TestCapacity();
                }

                else
                {
                    Console.WriteLine("Click any keys to exit");
                    break;
                }

                Console.Write("Would you like to back to main menu? (y/n): ");
            }
            while (Console.ReadLine() == "y");
            Console.WriteLine("Stop! click any keys to exit!");
            Console.ReadKey();
        }
    }
}

