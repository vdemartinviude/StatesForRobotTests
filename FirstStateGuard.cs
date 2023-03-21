using StatesAndEvents;
using TheRobot;

namespace StatesForTests;

public class FirstStateGuard : IGuard<FirstTestState, SecondTestState>
{
    public uint Priority => 10;

    public bool Condition(Robot robot)
    {
        return true;
    }

    public Task<bool> Condition(Robot robot, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}