using JEHomeTask.Utils;
using TechTalk.SpecFlow;

namespace JEHomeTask
{
    [Binding]
    class Hooks
    {
        [BeforeScenario]
        public void InitDriver()
        {
            BrowserUtils.CreateDriver();
        }

        [AfterScenario]
        public void CloseDriver()
        {
            BrowserUtils.CloseDriver();
        }
    }
}
