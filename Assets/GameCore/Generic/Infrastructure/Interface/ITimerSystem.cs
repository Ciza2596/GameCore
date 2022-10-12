using System;


namespace GameCore.Generic.Infrastructure
{
    public interface ITimerSystem
    {

        float  GetElapsedTime(string      id);
        float  GetRemainingTime(string    id);
        bool   IsTimerExist(string        id);
        Timer  RegisterLoopTimer(float    duration , Action callback);
        void   RegisterOnceTimer(string   id ,       float  duration , Action callback);
        string RegisterOnceTimer(float    duration , Action callback);
        void   UnRegisterOnceTimer(string id);
    }
}