using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Bank
    {
        Card[] cards =
        {
                new VisaElectron("VisaElectron"),
                new VisaDanKort("VisaDankort"),
                new MasterCard("MasterCard"),
                new Maestro("Maestro"),
                new Haevekort("Heavekort")
        };

        public Card GivePersonCard(string cardName, string cardHolderName)
        {
            Card card = null;
            switch (cardName)
            {
                case "maestro":
                    card = new Maestro(cardHolderName);
                    break;
                case "mastercard":
                    card = new MasterCard(cardHolderName);
                    break;
                case "haevekort":
                    card = new Haevekort(cardHolderName);
                    break;
                case "visaelectron":
                    card = new VisaElectron(cardHolderName);
                    break;
                case "visadankort":
                    card = new VisaDanKort(cardHolderName);
                    break;
                default:
                    card = new Haevekort(cardHolderName);
                    break;
            }
            return card;
        }

        public string ShowExamples(byte age)
        {
            string temp = string.Empty;

            foreach (Card card in cards)
            {
                if (card.AgeLimit <= age)
                {
                    temp += card.CardHolderName + "\n";
                }
                else if (card is Haevekort && age < card.AgeLimit)
                    temp += card.CardHolderName + "\n";
            }

            return temp;
        }
    }
}
