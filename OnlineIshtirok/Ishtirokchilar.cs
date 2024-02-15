using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineIshtirok
{
    public class Ishtirokchilar
    {   
        public string IshtirochilarIsmi()
        {
            string user = Console.ReadLine();

            if(user == "Nurmurod")
            {
                Console.WriteLine("Taqiqlangan");
            }
            if (user == "Lazizbek")
            {
                Console.WriteLine("Taqiqlangan");
            }
            if (user == "Zohidbek")
            {
                Console.WriteLine("Taqiqlangan");
            }
            return user;
        }
    }
}
