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
            Console.WriteLine(bank.ShowExamples(person.Age));


            Console.WriteLine("What card do you want");
            string cardChoice = Console.ReadLine().ToLower();
            Card card = bank.GivePersonCard(cardChoice, person.Name);

            Console.WriteLine(person.AddCardToWallet(card));



            Console.ReadKey();
        }
    }
}
