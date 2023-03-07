using StatesAndEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRobot;

namespace StatesForTests;

public class SecondStateGuard : IGuard<SecondTestState>
{
    public bool Condition(Robot robot)
    {
        return true;
    }
}