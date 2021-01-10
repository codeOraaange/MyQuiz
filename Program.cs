using System;

namespace QuizNeng
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior War1 = new Warrior ("War1",1000,100,50);
            Warrior War2 = new Warrior ("War2",500,200,50);

            Battle bt = new Battle();
            bt.StartFight(War1, War2);
            
            System.Console.ReadLine();
        }
    }
}
