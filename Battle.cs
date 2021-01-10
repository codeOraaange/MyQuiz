using System;

namespace QuizNeng
{
    class Battle
    {
        
        public void StartFight(Warrior warrior1, Warrior warrior2)
        {
            String NameA = warrior1.Name;
            int HealtA = warrior1.Healt;
            int MaxAttackA = warrior1.MaxAttack;
            int MaxBlockA = warrior1.MaxBlock;
            
            String NameB = warrior2.Name;
            int HealtB = warrior2.Healt;
            int MaxAttackB = warrior2.MaxAttack;
            int MaxBlockB = warrior2.MaxBlock;

            int attack1 = warrior1.Attack();
            int attack2 = warrior2.Attack();
            int block1 = warrior1.Block();
            int block2 = warrior2.Block();
            
            int serangA = HealtA;
            int serangB = HealtB ;
            int a=0;
            while (a==0)
            {
                if (attack1>block2){
                    serangB-= (attack1 - block2);
                    Console.WriteLine("War1 = "+serangA +" diserang War2 =  "+serangB);
                }if(attack2>block1){
                    serangA-= (attack2 - block1);
                    Console.WriteLine("War2 = "+serangB +" diserang War1 =  "+serangA);
                }
                if(serangA<=0 || serangB<=0){
                    a=1;
                }
            } 
            if (serangA<serangB){
                Console.WriteLine("\nPemenang = "+warrior2.Name);
            }else{
                Console.WriteLine("\nPemenang = "+warrior1.Name);
            } 
        }
    }
}