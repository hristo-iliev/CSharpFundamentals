//// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//// and stores it the current directory. Find in Google how to download files in C#.
//// Be sure to catch all exceptions and to free any used resources in the finally block.

namespace _04DownloadingFile
{
    using System;
    using System.Net;

    public class DownloadingFile
    {
        public static void Main()
        {
            try
            {
                WebClient download = new WebClient();
                download.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"..\..\Logo-BASD.jpg");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine();
                Console.Error.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine();
                Console.Error.WriteLine("Possibilities:");
                Console.Error.WriteLine("1) Invalid address.");
                Console.Error.WriteLine("2) The searched file is null.");
                Console.Error.WriteLine("3) The file does not exist.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine();
                Console.Error.WriteLine("The invoked method is not supported");
            }
            catch
            {
                Console.Error.WriteLine("System Error!");
            }            
        }
    }
}
