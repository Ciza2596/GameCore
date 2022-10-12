
using GameCore.Generic.Infrastructure;
using UnityEngine;


namespace GameCore.Generic.Implement.Derived
{
    public class TimeProvider : ITimeProvider
    {
        public float GetDeltaTime()
        {
            return Time.deltaTime;
        }

        public float GetTotalTime()
        {
            return Time.timeSinceLevelLoad;
        }
    }
}