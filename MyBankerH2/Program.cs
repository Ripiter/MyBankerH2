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
            //Card visa = new VisaElectron();
            //Card maestro = new Maestro();

            Card[] cards =
            {
                new VisaElectron("Rex"),
                new Maestro("Josef")
            };

            foreach (Card card in cards)
            {
                card.GenerateCard();
                if(card is IExpire)
                    Console.WriteLine(card.ToString());
                else
                    Console.WriteLine(card.ToString());
            }

            Console.ReadKey();
        }
    }
}
