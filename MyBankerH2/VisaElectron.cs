using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class VisaElectron : Card, IExpire
    {
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }
        private string expirationDate;


        public VisaElectron(string cardHolderName) : base(cardHolderName)
        {
            this.LenghtOfCard = 16;
            this.AgeLimit = 15;
            this.StartingNumbers = new string[]{
                "4026",
                "417500",
                "4508",
                "4844",
                "4913",
                "4917"
            };
            
        }

        public override void GenerateCard()
        {
            base.GenerateCard();
            CalculateExpireDate();
        }

        public void CalculateExpireDate()
        {
            ExpirationDate = DateTime.Now.ToString() + " + 5years";
        }


        public override string ToString()
        {
            //+" Expires " + ((IExpire)card).ExpirationDate
            return this.CardHolderName + " card with number " + this.CardNumber + " Expires " + this.ExpirationDate;
        }
    }
}
