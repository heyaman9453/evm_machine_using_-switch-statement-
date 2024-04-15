using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evm_machine_using__switch__statement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your  serial number to vote your desired party");
            Console.WriteLine("Press 1  to vote BJP candidate ");
            Console.WriteLine("Press 2 to vote congress candidate ");
            Console.WriteLine("Press 3  to vote TMC candidate ");
            Console.WriteLine("Press 4  to vote JANTA DAL candidate ");
             Console.WriteLine("Press 5 to vote NOTA ");
            Console.WriteLine("------------------------------------------------------- ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("congratulations ! You voted for the BJP candidate.");
                    break;
                case 2:
                    Console.WriteLine("congratulations ! You voted for the Congress candidate.");
                    break;
                case 3:
                    Console.WriteLine(" congratulations ! You voted for the TMC candidate.");
                    break;
                case 4:
                    Console.WriteLine("congratulations ! You voted for the Janta Dal candidate.");
                    break;
                case 5:
                    Console.WriteLine("congratulations ! You voted for NOTA (None of the above).");
                    break;
                default:
                    Console.WriteLine("Your vote is invalid.");
                    break;
            }
        Console.ReadLine()
;        }
    }
}
