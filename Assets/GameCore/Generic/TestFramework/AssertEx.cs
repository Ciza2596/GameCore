
using System;
using NUnit.Framework;


namespace GameCore.Generic.TestFrameWork
{
    public sealed class AssertEx
    {

        public static void NoExceptionThrown<T>(Action action) where T : Exception
        {
            try
            {
                action();
            }
            catch (T)
            {
                Assert.Fail("Expected no {0} to be thrown" , typeof(T).Name);
            }
        }
    }
}