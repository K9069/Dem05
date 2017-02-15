using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few person objects
            CDlevy levy1 = new Song
            {
                Album = "Kirsi",
                Artist = "Mainio",
                Song = "121212-1212"
                Time = "5:12"
            };
            CDlevy levy2 = new Song
            {
                Firstname = "Paavo",
                Lastname = "Puu",
                SocialSecurityNumber = "131313-1313"
            };
            CDlevy levy3 = new Song
            {
                Firstname = "Teppo",
                Lastname = "Karhunen",
                SocialSecurityNumber = "141414-1414"
            };
            // create a Persons object
            CDlevy levy = new CDlevy();

            // add person objects to persons collection
            levy.AddCDlevy(person1);
            levy.AddPerson(person2);
            levy.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = myFriends.GetPerson(10);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "131313-1313";
            Console.WriteLine("Find sotu : " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person with that sotu...");
            }
        }
    }
}
