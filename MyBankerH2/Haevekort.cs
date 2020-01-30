using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Haevekort : Card, IExpire
    {
        public Haevekort(string cardHolderName) : base(cardHolderName)
        {
            this.LenghtOfCard = 14;
            this.AgeLimit = 18;
            this.StartingNumbers = new string[]
            {
                "2400",
            };

            GenerateCard();
            CalculateExpireDate();
        }
        string expire;
        public string ExpirationDate { get => expire; set => expire = value; }

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
