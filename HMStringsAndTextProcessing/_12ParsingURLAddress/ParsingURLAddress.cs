//// Write a program that parses an URL address given in the format:
//// [protocol]://[server]/[resource]

namespace _12ParsingURLAddress
{
    using System;

    public class ParsingURLAddress
    {
        public static void Main()
        {
            string address = "http://www.introprogramming.info/intro-csharp-book/read-online/glava13-simvolni-nizove/";

            string protocol = "[protocol] = ";
            string server = "[server] = ";
            string resource = "[resource] = ";

            int i = 0;      

            while (address[i] != ':')
            {
                protocol += address[i];     
                i++;
            }
            i++;
            string currentServer = "";
            int slashCounter = 0;

            while (slashCounter != 3)
            {
                if (address[i] == '/') 
                {
                    slashCounter++;
                }
                currentServer += address[i];
                i++;
            }
            i--;

            currentServer = currentServer.Trim(new char[] { '/' }); 

            server += currentServer;        

            for (; i < address.Length; i++)
            {
                resource += address[i];
            }

            Console.WriteLine(address);
            Console.WriteLine();
            Console.WriteLine(protocol);        
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
