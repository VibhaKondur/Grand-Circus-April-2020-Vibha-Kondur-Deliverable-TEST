using System;

namespace Grand_Circus_April_2020_Vibha_Kondur_Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = "";
            string Destination = "";
            string TravelSuggestion = "";
            int GroupSize = 0;

            Console.WriteLine("What type of vacation do you want to go on - Musical, Tropical, or Adventurous?");
            vacationType = Console.ReadLine();

            //if (vacationType.ToLower() == "musical")
            if (vacationType == "Musical")
            {
                Destination = "New Orleans";    
            }
            else if (vacationType == "musical")
            {
                Destination = "New Orleans";
            }
            if (vacationType == "Tropical")
            {
                Destination = "Beach Vacation in Mexico";
            }
            else if (vacationType == "tropical")
            {
                Destination = "Beach Vacation in Mexico";
            }
            if (vacationType == "Adventurous")
            {
                Destination = "Whitewater Rafting the Grand Canyon";
            }
            else if (vacationType == "adventurous")
            {
                Destination = "Whitewater Rafting the Grand Canyon";
            }

            Console.WriteLine("How many people are you traveling with?");
            GroupSize = Convert.ToInt32(Console.ReadLine());
            if (GroupSize >= 1 && GroupSize <= 2)
            {
                TravelSuggestion = "First Class Flight";
            }
            else if (GroupSize >= 3 && GroupSize <= 5)
            {
                TravelSuggestion = "Helicopter ride";
            }
            else if (GroupSize >= 6)
            {
                TravelSuggestion = "Charter Flight";
            }

            //string template = "Since you're a group of {0} going on a {1} vacation, you should take a {2} to {3}.";
            //string formatted = string.Format(template, GroupSize, vacationType, TravelSuggestion, Destination);
            //Console.WriteLine(formatted);
            Console.WriteLine("Since you're a group of " + GroupSize + " going on a " + vacationType + " vacation, you should take a " + TravelSuggestion + " to " + Destination);
        }   
    }
}
    