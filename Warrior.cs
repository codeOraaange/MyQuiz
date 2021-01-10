using System;

namespace QuizNeng
{
    class Warrior
    {
        public string Name {get;set;}
        public int Healt {get;set;}
        public int MaxAttack {get;set;}
        public int MaxBlock {get;set;}
        
        public Warrior(string name, int healt, int maxAttack, int maxBlock )
        {
            Name = name;
            Healt = healt;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
        }

        public int Attack (){
            Random Rand = new Random();
            int hasil = Rand.Next(1,100);
            return hasil;
        }
        public int Block (){
            Random Rand = new Random();
            int hasil = Rand.Next(1,50);
            return hasil;
        }
    }
}
