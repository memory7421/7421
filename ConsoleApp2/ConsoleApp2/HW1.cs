using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HW1
    {
    }
}

abstract class Person
{
    public abstract bool Action();
}

class Pink : Person
{
    public override bool Action()
    {
        return true;
    }
}

class Black : Person
{
    public override bool Action()
    {
        return false;
    }
}

class Blue : Pink
{
    public new bool Action()
    {
        return base.Action();
    }
}

class Yellow : Pink
{
    public new bool Action()
    {
        if (base.Action() == true)
        {
            return false;
        }
        return base.Action();
    }
}