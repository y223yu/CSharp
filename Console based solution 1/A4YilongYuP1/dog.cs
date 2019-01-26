using System;

namespace A4YilongYuP1
{
    class dog
    {
        private string name;
        private string breed;
        private string color;
        private string gender;

        //default constructor
        public dog()
        {
        }
        //non-default constructor to store dog's information
        public dog(string inName, string inBreed, string inColor, string inGender)
        {
            name = inName;
            breed = inBreed;
            color = inColor;
            gender = inGender;
        }

        public void DisplayDogInformation(string name, string breed, string color, string gender)
        {
            if (name == "")
            {
                Console.WriteLine("No dog record exists.");
                Console.WriteLine("---------------------");
            }
            else
            {
                Console.WriteLine("Dog's name is: " + name);
                Console.WriteLine("Dog's breed is: " + breed);
                Console.WriteLine("Dog's color is: " + color);
                Console.WriteLine("Dog's gender is: " + gender);
                Console.WriteLine("--------------------------");
            }
        }

        public bool ExistDogInformation(string name)
        {
            if (name == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditDogInformation(string name)
        {
            if (name == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
