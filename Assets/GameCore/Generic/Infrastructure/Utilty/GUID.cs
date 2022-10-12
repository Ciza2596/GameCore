using System;


namespace GameCore.Generic.Infrastructure
{
    public class GUID
    {
        public static string NewGUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}