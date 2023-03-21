using Microsoft.Extensions.Logging;
using StatesAndEvents;
using TheRobot.MediatedRequests;

namespace StatesForTests;

public class FirstTestState : BaseState
{
    public override TimeSpan StateTimeout => TimeSpan.FromSeconds(3600);

    public FirstTestState(StateInfrastructure infrastructure) : base("FirstTestState", infrastructure)
    {
    }

    public override async Task Execute(CancellationToken token)
    {
        ILogger log = _stateInfra.LoggerFactory.CreateLogger("FirstTestState");
        log.LogCritical("Será que deu certo?");

        await _stateInfra.Robot.Execute(new MediatedNavigationRequest
        {
            Url = "http://www.rpachallenge.com"
        }, token);
    }
}