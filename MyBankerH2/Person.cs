using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerH2
{
    class Person
    {
        List<Card> cards = new List<Card>();

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private byte age;

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }



        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string AddCardToWallet(Card card)
        {
            cards.Add(card);
            return card.GetType() + " was added to persons wallet";
        }

    }
}
