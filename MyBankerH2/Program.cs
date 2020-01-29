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
            Card visa = new VisaElectron();
            Card maestro = new Maestro();

            Card[] cards =
            {
                new VisaElectron(),
                new Maestro()
            };

            foreach (Card card in cards)
            {
                card.GenerateCard();
                Console.WriteLine(card.CardNumber);
            }

            Console.ReadKey();
        }
    }
}
