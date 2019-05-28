using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enemy
    {
        abstract class Person
        {
            public abstract void Action(PlayerAction action);
        }

        class Pink : Person
        {
            public override void Action(PlayerAction action)
            {
                action = PlayerAction.Cooperation;
            }
        }
        
        class Black : Person
        {
            public override void Action(PlayerAction action)
            {
                action = PlayerAction.Deceive;
            }
        }
        /*
        class Blue : Pink
        {
            public new void Action()
            {
                return base.Action();
            }
        }

        class Yellow : Pink
        {
            public new void Action()
            {
                if (base.Action() == true)
                {
                    return false;
                }
                return base.Action();
            }
        }
        */
    }
}
