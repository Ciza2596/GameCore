
using System;


namespace GameCore.Generic.TestFrameWork
{
    public static class ScenarioExtension
    {
        public static Scenario And(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario Given(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario Then(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario When(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }
    }
}