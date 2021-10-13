using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
           bool mang = true;
            int usercounter = 0;
            int arvuticounter = 0;
            while (usercounter < 3 && arvuticounter < 3)
            {
               
                Console.WriteLine("1.kivi 2.paber või 3.käärid");
                string user = Console.ReadLine();
                Random rnd = new Random();
                int arvuti = rnd.Next(1, 4);
                
                if (arvuti == 1)
                {
                    if (user == "kivi")
                    {
                        Console.WriteLine("arvuti valis kivi");
                        Console.WriteLine("viik");
                    }
                    else if (user == "paber")
                    {
                        Console.WriteLine("arvuti valis kivi");
                        Console.WriteLine("sa võitsid!");
                        usercounter++;
                    }
                    else if (user == "käärid")
                    {
                        Console.WriteLine("arvuti valis kivi");
                        Console.WriteLine("arvuti võitis!");
                        arvuticounter++;
                    }

                }
                if (arvuti == 2)
                {
                    if (user == "kivi")
                    {
                        Console.WriteLine("arvuti valis paberi");
                        Console.WriteLine("arvuti võitis!");
                        arvuticounter++;
                    }
                    else if (user == "paber")
                    {
                        Console.WriteLine("arvuti valis paberi");
                        Console.WriteLine("viik");
                    }
                    else if (user == "käärid")
                    {
                        Console.WriteLine("arvuti valis paberi");
                        Console.WriteLine("sa võitsid!");
                        usercounter++;
                    }
                }
                if (arvuti == 3)
                {
                    if (user == "kivi")
                    {
                        Console.WriteLine("arvuti valis käärid");
                        Console.WriteLine("sa võitsid!");
                        usercounter++;
                    }
                    else if (user == "paber")
                    {
                        Console.WriteLine("arvuti valis käärid");
                        Console.WriteLine("arvuti võitis!");
                        arvuticounter++;
                    }
                    else if (user == "käärid")
                    {
                        Console.WriteLine("arvuti valis käärid");
                        Console.WriteLine("viik");
                        
                    }
                    
                }
                Console.WriteLine($"arvutil on {arvuticounter} punkti sul on {usercounter} punkte");

















            }
        }
    }
}
