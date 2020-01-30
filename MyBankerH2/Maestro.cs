using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Maestro : Card
    {
        public Maestro(string cardHolderName) : base(cardHolderName)
        {
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
            base.GenerateCard();
        }

        public override string ToString()
        {
            return this.CardHolderName + " card with number " + this.CardNumber;
        }
    }
}
