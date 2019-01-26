using System;

namespace A4YilongYuP1
{
    class MainClass
    {
        public static void Main()
        {
            string nameString = "", breedString = "";
            string colorString = "", genderString = "";
            string option;

            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Dog Data Maintenance Menu");
                Console.WriteLine("1: Display the name, breed, color, and gender of the dog.");
                Console.WriteLine("2: Add a new dog.");
                Console.WriteLine("3: Edit an existing dog.");
                Console.WriteLine("4: Exit the program.");
                Console.WriteLine("-------------------");

                option = Console.ReadLine();   //user choose options

                switch (option)
                {
                    case "1":   //call method to display dog information
                        dog displayDog = new dog();
                        displayDog.DisplayDogInformation(nameString, breedString, colorString, genderString);
                        option = "";
                        break;

                    case "2":  //call non-default constructor to enter dog information
                        dog existDog = new dog();
                        if (existDog.ExistDogInformation(nameString))
                        {
                            Console.WriteLine("Please enter dog's name: ");
                            nameString = Console.ReadLine();
                            Console.WriteLine("Please enter dog's breed: ");
                            breedString = Console.ReadLine();
                            Console.WriteLine("Please enter dog's color: ");
                            colorString = Console.ReadLine();
                            Console.WriteLine("Please enter dog's gender(male or female): ");
                            genderString = Console.ReadLine();

                            while (genderString != "male" && genderString != "female")
                            {
                                Console.WriteLine("Invalid enter!");
                                Console.WriteLine("You must enter male or female by lower case.");
                                Console.WriteLine("Please enter dog's gender again: ");
                                genderString = Console.ReadLine();
                                if (genderString == "male" && genderString == "female")
                                {
                                    break;
                                }
                            }
                            /**
                            do
                            {
                                Console.WriteLine("Please enter dog's gender(male or female): ");
                                genderString = Console.ReadLine();
                            } while (genderString != "male" && genderString != "female");
                            **/

                            Console.WriteLine("information entering success!");
                            Console.WriteLine("-----------------------------");

                            dog inputdog;
                            inputdog = new dog(nameString, breedString, colorString, genderString);
                        }
                        else
                        {
                            Console.WriteLine("Dog information already exists.");
                        }
                        option = "";
                        break;

                    case "3":   //call method to edit dog information 
                        dog editDog = new dog();
                        if (editDog.EditDogInformation(nameString))
                        {
                            Console.WriteLine("No dog record exists.");
                            Console.WriteLine("---------------------");
                        }
                        else
                        {
                            Console.WriteLine("Please edit dog's name: ");
                            nameString = Console.ReadLine();
                            Console.WriteLine("Please edit dog's breed: ");
                            breedString = Console.ReadLine();
                            Console.WriteLine("Please edit dog's color: ");
                            colorString = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Please edit dog's gender(male or female): ");
                                genderString = Console.ReadLine();
                            } while (genderString != "male" && genderString != "female");

                            dog inputdog;
                            inputdog = new dog(nameString, breedString, colorString, genderString);

                            Console.WriteLine("information editing success!");
                            Console.WriteLine("-----------------------------");
                        }
                        option = "";
                        break;

                    case "4":
                        Console.WriteLine("Please press any key to exit.");
                        break;
                }
            } while (option != "1" && option != "2" && option != "3" && option != "4");

            Console.ReadLine();
        }
    }
}
