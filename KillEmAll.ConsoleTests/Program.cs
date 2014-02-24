using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillEmAll.Common;

namespace KillEmAll.ConsoleTests
{
    public class Program
    {
        private static Player GeneratePlayer()
        {
            return new Player("James Hetfield")
            {
                Health = 100,
                AttackSkill = 6,
                DefenseSkill = 5
            };
        }

        private static Enemy GenerateEnemy()
        {
            return new Enemy("Justin")
            {
                Health = 80,
                AttackSkill = 4,
                DefenseSkill = 2
            };
        }

        private static void TestVerySimpleBattleManager()
        {
            IBattleManager man = new VerySimpleBattleManager();

            //  james strikes first
            Player james = GeneratePlayer();
            Enemy justin = GenerateEnemy();

            Console.WriteLine(james);
            Console.WriteLine(justin);

            man.ResolveBattle(james, justin);

            Console.WriteLine(james);
            Console.WriteLine(justin);

            //  justin strikes first
            james = GeneratePlayer();
            justin = GenerateEnemy();

            Console.WriteLine(james);
            Console.WriteLine(justin);

            man.ResolveBattle(justin, james);

            Console.WriteLine(james);
            Console.WriteLine(justin);

        }

        static void Main(string[] args)
        {
            TestVerySimpleBattleManager();

            Console.ReadLine();
        }
    }
}
