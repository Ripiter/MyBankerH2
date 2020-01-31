using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Maestro : Card, IExpire
    {
        public Maestro(string cardHolderName) : base(cardHolderName)
        {
            this.AgeLimit = 18;
            this.StartingNumbers = new string[]
            {
                "5018",
                "5020",
                "5038",
                "5893",
                "6304",
                "6759",
                "6761",
                "6762",
                "6763"
            };

            this.LenghtOfCard = 19;
        }

        public override void GenerateCard()
        {
            CalculateExpireDate();
            base.GenerateCard();
        }

        public string ExpirationDate { get => expire; set => expire = value; }
        string expire;
        public void CalculateExpireDate()
        {
            ExpirationDate = DateTime.Now + " 5,8 years";
        }

        

        public override string ToString()
        {
            return this.CardHolderName + " card with number " + this.CardNumber + " Expires " + this.ExpirationDate;
        }
    }
}
