using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Pet
{
    public class PetShop
    {
        public List<FantasyPet> PetList { get; set; } 

       public PetShop()
        {
            PetList = new List<FantasyPet>();

        }
        public string AddPet(FantasyPet pet)  //Adds pets to the list
        {
            PetList.Add(pet);
            return ($"You successfully added {pet} to the shop!");
        }

        public void listPets() //Lists all the pets
        {
            foreach (var pet in PetList)
                Console.WriteLine(pet.describePet());
            Console.WriteLine();

        }

            
    }
}
