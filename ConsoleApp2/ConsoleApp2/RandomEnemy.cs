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
        }
        public override string ToString()
        {
            return "Your enemy is "+ enemyType;
        }
    }
}
