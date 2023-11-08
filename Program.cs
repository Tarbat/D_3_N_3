using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


class HelloWorld
{

    public static int checkingBrackets(String line)
    {
        int opening = 0;
        int QualOpen = 0;
        int closing = 0;
        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (c == '(') { opening++; QualOpen++;}
            if (c == ')') { closing++; QualOpen--;}
            if (opening == closing) { opening = 0; closing = 0;}
            if (closing > opening) { Console.Write("The first extra ')' = "); return i; }
        }
        if (QualOpen == 0) { return 0; }
        Console.Write("The number of extra '(' = ");
        return QualOpen;
    }

    static void Main()
    {
        String row; int a;

        Console.Write("Text - ");
        row = Console.ReadLine();

        a = checkingBrackets(row);
        if (a == 0) {Console.Write("Everything is correct"); return;}
        Console.Write(a);
    }
}