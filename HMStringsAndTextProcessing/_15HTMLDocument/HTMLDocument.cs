//// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
//// with corresponding tags [URL=…]…[/URL].

namespace _15HTMLDocument
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HTMLDocument
    {
        public static void Main()
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            string output = html.Replace("<a href=", "[URL=");
            output = output.Replace("</a>", "[/URL]");

            StringBuilder text = new StringBuilder();

            text.Append(output);

            Stack<int> indexOfBracket = new Stack<int>();

            int indexCounter = 0;

            while (output.IndexOf("[URL=", indexCounter+1) != -1)
            {
                indexCounter = output.IndexOf("[URL=", indexCounter);
                indexOfBracket.Push(output.IndexOf(">", indexCounter));
                indexCounter = indexOfBracket.Peek() + 1;
                
            }

            while (indexOfBracket.Count != 0)
            {
                text.Remove(indexOfBracket.Peek(),1);
                text.Insert(indexOfBracket.Pop(), "]");
            }

            Console.WriteLine(text);
        }
    }
}
