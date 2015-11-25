using System;

namespace StupidBullshit
{
    class Program
    {
        static void Main(string[] args)
        {
            StupidClass stupid = new StupidClass();
            stupid.listStupider();
            for (int i = 0; i < stupid.stupidList.Count; i++)
            Console.WriteLine(stupid.stupidList[i]);
        }
    }
}
