using System;
using NUnit.Framework;


namespace GameCore.Generic.TestFrameWork
{
    public class SimpleTest
    {
        protected readonly int _number = 999;
        protected readonly string _id = "id";


        protected string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        protected Scenario Scenario(string annotation)
        {
            return new Scenario();
        }

        protected void ShouldExceptionThrown<T>(Action action, string expectedMessage) where T : Exception
        {
            var exception = Assert.Throws<T>(() => action());
            var message = exception.Message;
            Assert.AreEqual(expectedMessage, message, "message is not equal");
        }

        protected void ShouldNoExceptionThrown<T>(Action action) where T : Exception
        {
            AssertEx.NoExceptionThrown<T>(action.Invoke);
        }
    }
}