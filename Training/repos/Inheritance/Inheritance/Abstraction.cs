using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class MobilePhone
    {
        protected void typingMessage()
        {
            Console.WriteLine("Message is typing\n");
        }

        protected void internalProcessing()
        {
            Console.WriteLine("Internal Processing Happening To send Message\n");
        }

    }

    public class Message : MobilePhone
    {

        public void displayMessage()
        {
            typingMessage();
            internalProcessing();

            Console.WriteLine("Message sent Successfully\n.");
            Console.ReadLine();
        }
    }

    

    
}
