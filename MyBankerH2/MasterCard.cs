using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class MasterCard : Card, IExpire
    {
        public MasterCard(string cardHolderName) : base(cardHolderName)
        {
            this.LenghtOfCard = 14;
            this.AgeLimit = 18;

            this.StartingNumbers = new string[]
            {
                "51",
                "52",
                "53",
                "54",
                "55"
            };
        }

        public override void GenerateCard()
        {
            base.GenerateCard();
            CalculateExpireDate();
        }

        public string ExpirationDate { get => expire; set => expire = value; }
        string expire;
        public void CalculateExpireDate()
        {
            ExpirationDate = DateTime.Now + " + 5years";
        }

        public override string ToString()
        {
            return this.CardHolderName + " card with number " + this.CardNumber + " Expires " + this.ExpirationDate;
        }
    }
}
