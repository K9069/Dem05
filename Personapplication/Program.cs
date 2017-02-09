using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Mainio",
                SocialSecurityNumber = "121212-1212"
            };
            Person person2 = new Person
            {
                Firstname = "Paavo",
                Lastname = "Puu",
                SocialSecurityNumber = "131313-1313"
            };
            Person person3 = new Person
            {
                Firstname = "Teppo",
                Lastname = "Karhunen",
                SocialSecurityNumber = "141414-1414"
            };
            // create a Persons object
            Persons myFriends = new Persons();

            // add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

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