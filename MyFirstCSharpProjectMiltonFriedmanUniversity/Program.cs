using System;

namespace FirstProjectMiltonFriedmanUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Hello");
            Console.Write(" ");
            Console.WriteLine("World!");
            Console.Write("Hello");
            Console.Write(" ");
            Console.Write("World!");
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            string s = Console.ReadLine();
            Console.WriteLine("WoW, I did it!");
            Console.WriteLine(s);

            char c;
            c = 'A';
            Console.WriteLine(c);
            Console.WriteLine('A');
            Console.WriteLine("A");
            Console.WriteLine("The value of c is: " + c);


            string s0 = "";
            string s1 = " ";
            string s2 = "Béla";
            string s3 = s2;
            string s4 = ("Alma");
            string s5 = s4 + s2;
            string s55 = s5.ToUpper();
            string s6 = string.Concat(s4, s1, s3);
            string s7 = s4.Substring(0, 2);
            string s8 = s5.Substring(2, 3).ToLower();

            Console.WriteLine(s0);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s55);
            Console.WriteLine("s6: " + s6);
            Console.WriteLine("s7: " + s7);
            Console.WriteLine("s8: " + s8);  
        }
    }
}
