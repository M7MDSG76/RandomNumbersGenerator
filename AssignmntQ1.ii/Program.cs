using System;

namespace AssignmntQ1.ii
{
    class Program
    {
        //Q1.2.2
        static void Main(string[] args)
        {
            Console.WriteLine("*******************WELLCOME TO THE RANDOM NUMBERS GENERATOR*******************");
            Console.WriteLine("-Enter the number of Random numbers: ");
            int RandomNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 0; i < RandomNum; i++)
            {
                Random X = new Random();
                int Randomnum = X.Next();
                Console.WriteLine($"*******************Random Numbers___#{i+1}");
                Console.WriteLine(Randomnum+"\n\n");
            }
        }
    }
}
