using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    abstract class Card
    {
        public Card(string cardHolderName)
        {
            this.CardHolderName = cardHolderName;
            this.StartingNumbers = startingNumbers;
            this.AgeLimit = ageLimit;
        }
        

        private string cardHolderName;

        public string CardHolderName
        {
            get { return cardHolderName; }
            set { cardHolderName = value; }
        }

        private byte ageLimit;

        public byte AgeLimit
        {
            get { return ageLimit; }
            protected set { ageLimit = value; }
        }


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
            MakeCardPretty();
        }

        void MakeCardPretty()
        {
            for (int i = 4; i < LenghtOfCard + prefix.Length; i += 5)
            {
                cardNumber = cardNumber.Insert(i, " ");
            }
        }


        public void AddBankAcountNumber(string bankAcountNumber)
        {
            CardNumber = CardNumber.Insert(0, bankAcountNumber + " ");
        }
        

    }
}
