using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Tesk_Console
{
    class Program
    {
        static void Message()
        {
            Console.WriteLine("I am The Worker Thread");
        }


        static void Main(string[] args)
        {
            Action a = new Action(Message);

            Task t = new Task(a);

            t.Start();
            Console.WriteLine("Main Thread Done");
        }
    }
}
