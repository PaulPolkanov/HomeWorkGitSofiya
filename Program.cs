using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGitSofiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFeel, userMsg;
            Console.WriteLine("как дела?");
            userMsg = Console.ReadLine();
            userFeel = userMsg;
            if (userFeel == "хорошо")
            {
                Console.WriteLine("что у вас случилось хорошео?");
            
            }
            else if (userFeel == "плохо")
            {
                Console.WriteLine("что у вас случилось плохого?");
                
               
            }
            else
            {
                Console.WriteLine("продолжай");
            }
            userMsg = Console.ReadLine();
            if (userFeel == "хорошо")
            {
                Console.WriteLine("круто");
            }    
           else if (userFeel == "плохо"){

                Console.WriteLine("бывает");

            }
           else
            {
                Console.WriteLine("ну ладно");
            }
        }

    }
}
