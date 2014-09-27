//// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//// Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03IOReadAllText
{    
    using System;
    using System.IO;
    using System.Security;

    public class IOReadAllText
    {
        public static void Main()
        {
            string path = @"C:\WINDOWS\win.ini";
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("Path is null.");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("Possibilities:");
                Console.Error.WriteLine("1) The file is a zero-length string.");
                Console.Error.WriteLine("2) The file contains only white space.");
                Console.Error.WriteLine("3) The file contains invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("Possibilities:");
                Console.Error.WriteLine("1) The path of the file is too long. (Paths must be less than 248 characters)");
                Console.Error.WriteLine("2) The file name is too long. (File names must be less than 260 characters.)");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("Directory not found.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("The file is missing.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("This operation is not supported on your platform.");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("The file isn't a text document.");
            }
            catch (SecurityException)
            {
                Console.Error.WriteLine("Error!");
                Console.Error.WriteLine("The caller does not have the permission to open the file.");
            }
            catch
            {
                Console.Error.WriteLine("System Error!");
            }       
        }
    }
}
