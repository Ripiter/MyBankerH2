using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    abstract class Card
    {
        int lenghtOfCard;
        string[] startingNumbers;
        string cardNumber;

        public string CardNumber
        {
            get
            {
                return cardNumber;
            }
            protected set
            {
                cardNumber = value;
            }
        }

        protected string[] StartingNumbers { get => startingNumbers; set => startingNumbers = value; }
        protected int LenghtOfCard { get => lenghtOfCard; set => lenghtOfCard = value; }

        string prefix;
        public virtual void GenerateCard()
        {
            prefix = StartingNumbers[new Random().Next(0, StartingNumbers.Length)];
            cardNumber += prefix;
            for (int i = 0; i < LenghtOfCard - prefix.Length; i++)
            {
                cardNumber += new Random(Guid.NewGuid().GetHashCode()).Next(0, 10);
            }
            MakePretty();
        }

        void MakePretty()
        {
            for (int i = 4; i < LenghtOfCard + prefix.Length; i += 5)
            {
                cardNumber = cardNumber.Insert(i, " ");
            }
        }

       

    }
}
