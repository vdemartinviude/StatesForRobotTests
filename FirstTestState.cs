using JsonDocumentsManager;
using StatesAndEvents;
using TheRobot;
using TheRobot.MediatedRequests;

namespace StatesForTests;

public class FirstTestState : BaseState
{
    public override TimeSpan StateTimeout => TimeSpan.FromSeconds(3600);

    public FirstTestState(Robot robot, InputJsonDocument inputdata, ResultJsonDocument resultJson) : base("FirstTestState", robot, inputdata, resultJson)
    {
    }

    public override async Task Execute(CancellationToken token)
    {
        await _robot.Execute(new MediatedNavigationRequest
        {
            Url = "http://www.rpachallenge.com"
        }, token);
    }
}