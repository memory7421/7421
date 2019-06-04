using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RandomEnemy
    {
        public EnemyType enemyType;
        public RandomEnemy()
        {
            Random random = new Random();
            enemyType = (EnemyType)random.Next(0, 2);
            //int randomNumber = random.Next(0, 2);
            //enemyType = RandomEnemyType(randomNumber);
        }
        /*
        public EnemyType RandomEnemyType(int i)
        {
            switch (i)
            {
                case 0:return EnemyType.Pink;
                case 1: return EnemyType.Black;
                default: throw new Exception();
            }
        }
        public Enemy EnemyAction(int i)
        {
            switch (i)
            {
                case 0: return Enemy.Pink.Action();
                case 1: return Enemy.Black.Action();
                default: throw new Exception();
            }
        }
        */
        public override string ToString()
        {
            return "Your enemy is " + enemyType;
        }
    }
}
