using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Books
    {
        //variabler
        public int price = 0;
        
        int rarity = 0;
        
        int actualValue = 0;
        bool cursed = false;

       
        
        
        static Random generator = new Random();



        public void Book()
        {
           


            actualValue = generator.Next(101);
            rarity = generator.Next(5);


        }   


        public void Printinfo(int index1, int index2, string cursecheck)
        {
            //skriver ut alla värderna på boken som spelaren ska veta
            Console.WriteLine("Value of the " + index1 + " book " + index2 + " is " + actualValue + " and it has the rarity " + rarity + ". Is the book cursed? " + cursecheck);
        }

        public int Evaluate()
        {
            //bestämmer hur mycket allt är värt
            int price = actualValue * rarity;
            int oneortwo = generator.Next(1);

            if (oneortwo == 0)
            {
                price = price / 2;
            }
            else
            {
                price = price / 2 + price;
            }

            return price;
        }

        public int GetCategory()
        {
            //listan med katgorier som räknas och sedan kommer de antalet kategorier slumpas och ett skrivs ut
            List<string> Category = new List<string>() { "Fantasy", "Horror", "History", "Kids" };
            int index1 = generator.Next(Category.Count);
            string placeatlist1 = Category[index1];

            return index1;
        }

        public string GetnName()
        {
            List<string> Name = new List<string>() { "Book1", "Book2", "Book3", "Book4" };
            int index2 = generator.Next(Name.Count);
            string placeatlist2 = Name[index2];

            return placeatlist2;
        }

        public bool IsCursed()
        {
            //kollar om random generator är över eller under 80% om den blir cursed eller inte
            string cursecheck = "";

            int isitcursed = generator.Next(101);
            if (isitcursed < 80)
            {
                cursed = true;
                cursecheck = "yes";
            }
            else
            {
                cursed = false;
                cursecheck = "no";

            }

            return cursed;
        }

    }
}

