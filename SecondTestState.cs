using JsonDocumentsManager;
using OpenQA.Selenium;
using StatesAndEvents;
using TheRobot;
using TheRobot.MediatedRequests;

namespace StatesForTests;

public class SecondTestState : BaseState
{
    public SecondTestState(Robot robot, InputJsonDocument inputdata, ResultJsonDocument resultJson) : base("SecondTestState", robot, inputdata, resultJson)
    {
    }

    public override async Task Execute(CancellationToken token)
    {
        await _robot.Execute(new MediatedClickRequest
        {
            BaseParameters = new() { By = By.XPath("//button[text()='Start']"), TimeOut = TimeSpan.FromSeconds(5) },
            Kind = KindOfClik.ClickByDriver
        }, token);
        for (int i = 0; i < 10; i++)
        {
            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Address']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].Address")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Company Name']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].CompanyName")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Last Name']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].LastName")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Phone Number']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].PhoneNumber")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='First Name']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].FirstName")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Role in Company']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].RoleInCompany")
            }, token);

            await _robot.Execute(new MediatedSetTextRequest
            {
                BaseParameters = new() { By = By.XPath("//label[text()='Email']/../input") },
                KindOfSetText = KindOfSetText.SetByWebDriver,
                TextToSet = _inputData.GetStringData($"$.Records[{i}].Email")
            }, token);

            await _robot.Execute(new MediatedClickRequest
            {
                BaseParameters = new() { By = By.XPath("//input[@type='submit']") },
                Kind = KindOfClik.ClickByDriver
            }, token);
        }
    }
}