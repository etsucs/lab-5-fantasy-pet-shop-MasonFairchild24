namespace Magic_Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetShop petShopMain = new PetShop();
            FantasyPet petOne = new FantasyPet("Todd", "Pheonix", 3, 799); //These all just describe the pets
            FantasyPet petTwo = new FantasyPet("Rainbows", "Dragon", 1, 999);
            FantasyPet petThree = new FantasyPet("Morg, the mutilator", "Unicorn", 8, 5);
            FantasyPet petFour = new FantasyPet("Soos", "Jackalope", 2, 399);
            FantasyPet petFive = new FantasyPet("Throngler", "Puffle", 20, 1999);


            petShopMain.PetList.Add(petOne); // 0
            petShopMain.PetList.Add(petTwo); // 1
            petShopMain.PetList.Add(petThree);//2
            petShopMain.PetList.Add(petFour);// 3
            petShopMain.PetList.Add(petFive);// 4

            petShopMain.listPets(); //This lists all the pets and describes them. 

            Console.WriteLine();
            Console.WriteLine($"{petShopMain.PetList[1].Name}'s price with the current discount is ${petShopMain.PetList[1].DiscountPrice(0.2m)}"); //This takes the percent off and returns the discounted price. 20% discount
            Console.WriteLine();
            Console.WriteLine($"{petShopMain.PetList[3].Name}'s price with the current discount is ${petShopMain.PetList[3].DiscountPrice(0.4m)}"); // 45% discount

            petShopMain.PetList[1].PerformMagic(); //Performs magic.
            Console.WriteLine();
            petShopMain.PetList[3].PerformMagic();




        }
    }
}
