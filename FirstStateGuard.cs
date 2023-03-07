using StatesAndEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRobot;

namespace StatesForTests;

public class FirstStateGuard : IGuard<FirstTestState, SecondTestState>
{
    public uint Priority => 10;

    public bool Condition(Robot robot)
    {
        return true;
    }
}