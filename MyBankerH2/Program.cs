using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Card maestro = new Maestro();
            Person person = new Person("Rotatan", 50);
            Bank bank = new Bank();
            string examples = bank.ShowExamples(person.Age);
            Console.WriteLine(examples);

            Console.WriteLine("What card do you want");
            string cardChoice = Console.ReadLine();
            Card card = bank.GivePersonCard(cardChoice, person.Name, examples);
            if(card != null)
                Console.WriteLine(person.AddCardToWallet(card));
            else
                Console.WriteLine("You cant have that card or wrong input");


            Console.ReadKey();
        }
    }
}
