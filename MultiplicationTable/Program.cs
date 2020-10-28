using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int calc;
            Console.WriteLine(" *  *  *  九九の表  *  *  *");

            for (int virticalTable = 1; virticalTable < 10; virticalTable++)
            {
                Console.WriteLine(" ");
                for (int horizontalTable = 1; horizontalTable < 10; horizontalTable++)
                {
                    calc = virticalTable * horizontalTable;
                    Console.Write("{0,3}",calc);

                }
            }
            Console.ReadKey();
        }
        
    }
}
