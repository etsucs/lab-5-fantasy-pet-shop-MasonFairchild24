
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Magic_Pet
{
    public class FantasyPet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }

        private static List<string> MagicPowerList = new List<string>
        {
            "Breathes Fire", "Casts healing spells", "Has telekenisis", "Flies", "Can stop Time"
        };

        public FantasyPet(string petName, string petSpecies, int petAge, decimal petPrice)
        {
            Name = petName;
            Species = petSpecies; //Dragon, Pheonix, Unicorn, Jackalope, Puffle (Club penguin, RIP) 
            Age = petAge;
            Price = petPrice;

            bool invalidMagicPower = true;
            while (invalidMagicPower)
            {
                try //Tries this and loops until it is correct
                {
                    Console.WriteLine($"Please enter {petName}'s magic ability (Breathes Fire, Casts healing spells, Has telekenisis, Flies, or Can stop Time)");
                    string petMagicPower = Console.ReadLine();
                    if (MagicPowerList.Contains(petMagicPower))
                    {
                        MagicPower = petMagicPower; //Breathes fire, casts healing spells, Telekenisis, Flies, Stop Time
                        invalidMagicPower = false;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid power, please select one of the powers we have documented");
                    }
                }
                catch (Exception ex) // Catches any errors and continues the loop instead of exiting the program
                {
                    Console.WriteLine("Sorry, something unexpected happened. Try again.");
                }
            }


            
        }
        public string describePet()
        {
            return($"{Name} is a {Age} year old {Species} that {MagicPower}, they are being sold for {Price}.");
        }

        public decimal DiscountPrice(decimal Percent)
        {

            return Price - (Price * Percent );
        }

        public void PerformMagic()
        {
            if (MagicPower == "Breathes fire") //Describes all the magic and what it says when they perform it.
                Console.WriteLine ($"{Name} opens it mouth and a small flame spews forward");
            else if (MagicPower == "Casts healing spells")
                Console.WriteLine ($"{Name} shuts it eyes and you start to somehow magically feel better");
            else if (MagicPower == "Has telekenisis")
                Console.WriteLine($"{Name} stares intently at a marble across the room and it begins to levitate");
            else if (MagicPower == "Flies")
                Console.WriteLine($"{Name} jumps into the air and starts to slowly fly across the room before landing back on the ground");
            else if (MagicPower == "Can stop Time")
                Console.WriteLine($"{Name} lets out a small roar and suddenly they are across the room and the furniture is rearranged");
            else
                Console.WriteLine($"Well, sadly I dont think this one has a power. ");

        }
    }
}
