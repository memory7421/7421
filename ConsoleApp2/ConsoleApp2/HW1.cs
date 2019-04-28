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

class person
{
    Action action();
}

class pink : person
{
    override Action action()
    {
        return true;
    }
}

class black : person
{
    override Action action()
    {
        return false;
    }
}

class blue : pink
{
    Action action(person a);
}

class yellow : pink
{
    if (action(person a)==false)
    {
        override Action action()
        {
            return false
}