using System;

namespace Assignment_5
{
    class Reservation
    {
        private string nName;
        private string nRow;
        private string columnString;
        private int nColumn;

        private string[] arr1 = new string[4];
        private string[] arr2 = new string[4];
        private string[] arr3 = new string[4];
        private string[] arr4 = new string[4];
        public Reservation()  //method to store the seats arrangement
        {
            for (int i = 0; i < 4; i++)
            {
                int x = i + 1;
                arr1[i] = "seat 1" + "-" + x;
                arr2[i] = "seat 2" + "-" + x;
                arr3[i] = "seat 3" + "-" + x;
                arr4[i] = "seat 4" + "-" + x;
            }
        }

        public void DisplaySeat()
        {
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("" + arr1[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("" + arr2[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("" + arr3[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("" + arr4[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
        }

        public void ReserveSeat()
        {
            Console.Write("Please select a ROW (1, 2, 3, 4): ");
            nRow = Console.ReadLine();
            while (nRow != "1" && nRow != "2" && nRow != "3" && nRow != "4")
            {
                Console.WriteLine("INVALID. Please select from 1, 2, 3, 4.");
                nRow = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                if (nRow == "1" || nRow == "2" || nRow == "3" || nRow == "4")
                {
                    break;
                }
            }

            Console.Write("Please select a SEAT (1, 2, 3, 4): ");
            columnString = Console.ReadLine();
            while (columnString != "1" && columnString != "2" && columnString != "3" && columnString != "4")
            {
                Console.WriteLine("INVALID. Please select from 1, 2, 3, 4.");
                columnString = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                if (columnString == "1" || columnString == "2" || columnString == "3" || columnString == "4")
                {
                    break;
                }
            }
            nColumn = int.Parse(columnString);
            int y = nColumn - 1;

            switch (nRow)
            {
                case "1":

                    if (arr1[y] != "seat 1" + "-" + nColumn)
                    {
                        Console.WriteLine("This seat has been reserved.");
                        Console.WriteLine("----------------------------------");
                        break;  //the break is a must to stop the if keeping running
                    }

                    Console.Write("Please enter customer's name: ");
                    nName = Console.ReadLine();
                    Console.WriteLine("--------------------------------------");

                    arr1[y] = nName + "\t";

                    break;

                case "2":
                    if (arr2[y] != "seat 2" + "-" + nColumn)
                    {
                        Console.WriteLine("This seat has been reserved.");
                        Console.WriteLine("----------------------------------");
                        break;
                    }

                    Console.Write("Please enter customer's name: ");
                    nName = Console.ReadLine();
                    Console.WriteLine("--------------------------------------");

                    arr2[y] = nName + "\t";
                    break;

                case "3":
                    if (arr3[y] != "seat 3" + "-" + nColumn)
                    {
                        Console.WriteLine("This seat has been reserved.");
                        Console.WriteLine("----------------------------------");
                        break;
                    }

                    Console.Write("Please enter customer's name: ");
                    nName = Console.ReadLine();
                    Console.WriteLine("--------------------------------------");

                    arr3[y] = nName + "\t";
                    break;

                case "4":
                    if (arr4[y] != "seat 4" + "-" + nColumn)
                    {
                        Console.WriteLine("This seat has been reserved.");
                        Console.WriteLine("----------------------------------");
                        break;
                    }

                    Console.Write("Please enter customer's name: ");
                    nName = Console.ReadLine();
                    Console.WriteLine("--------------------------------------");

                    arr4[y] = nName + "\t";
                    break;
            }
        }

        public void RemoveByName()
        {

            Console.Write("Please enter customer's name: ");
            nName = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < 4; i++)
            {
                int z = i + 1;
                if (arr1[i] == nName + "\t")    //the \t is a must to match method of ReserveSeat
                {
                    arr1[i] = "seat 1" + "-" + z;
                }

                if (arr2[i] == nName + "\t")
                {
                    arr2[i] = "seat 2" + "-" + z;
                }

                if (arr3[i] == nName + "\t")
                {
                    arr3[i] = "seat 3" + "-" + z;
                }

                if (arr4[i] == nName + "\t")
                {
                    arr4[i] = "seat 4" + "-" + z;
                }
            }
        }

        public void RemoveBySeat()
        {
            Console.Write("Please enter the ROW number (1, 2, 3, 4): ");
            nRow = Console.ReadLine();
            while (nRow != "1" && nRow != "2" && nRow != "3" && nRow != "4")
            {
                Console.WriteLine("INVALID. Please select from 1, 2, 3, 4.");
                nRow = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                if (nRow == "1" || nRow == "2" || nRow == "3" || nRow == "4")
                {
                    break;
                }
            }

            Console.Write("Please enter the SEAT number: ");
            columnString = Console.ReadLine();
            while (columnString != "1" && columnString != "2" && columnString != "3" && columnString != "4")
            {
                Console.WriteLine("INVALID. Please select from 1, 2, 3, 4.");
                columnString = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                if (columnString == "1" || columnString == "2" || columnString == "3" || columnString == "4")
                {
                    break;
                }
            }
            nColumn = int.Parse(columnString);
            int a = nColumn - 1;
            Console.WriteLine("----------------------------------------------");

            switch (nRow)
            {
                case "1":
                    arr1[a] = "seat 1" + "-" + nColumn;
                    break;
                case "2":
                    arr2[a] = "seat 2" + "-" + nColumn;
                    break;
                case "3":
                    arr3[a] = "seat 3" + "-" + nColumn;
                    break;
                case "4":
                    arr4[a] = "seat 4" + "-" + nColumn;
                    break;
            }
        }

        public void TestCapacity()
        {
            for (int i = 0; i < 4; i++)
            {
                arr1[i] = "RESERVED" + "\t";
                arr2[i] = "RESERVED" + "\t";
                arr3[i] = "RESERVED" + "\t";
                arr4[i] = "RESERVED" + "\t";
            }
            Console.WriteLine("All seats have been reserved.");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
