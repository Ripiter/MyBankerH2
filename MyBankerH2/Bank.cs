﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Bank
    {
        Card[] possibleCards =
        {
                new VisaElectron("VisaElectron"),
                new VisaDanKort("VisaDankort"),
                new MasterCard("MasterCard"),
                new Maestro("Maestro"),
                new Haevekort("Heavekort")
        };

        public Card GivePersonCard(string cardName, string cardHolderName, string posibilites)
        {
            if (!posibilites.Contains(cardName))
                return null;

            Card card = null;

            foreach (Card item in possibleCards)
            {
                if(item.CardHolderName == cardName)
                {
                    item.CardHolderName = cardHolderName;
                    card = item;
                }
            }
            

            //Generate new card number for the person
            card.GenerateCard();
            return card;
        }

        public string ShowExamples(byte age)
        {
            string temp = string.Empty;

            foreach (Card card in possibleCards)
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
