﻿using UnityEngine;

namespace MlcUnity
{
    public class MlcLog
    {
        public delegate void DelegateLogFunction(string message);

        public static DelegateLogFunction LogFunction;
        public static DelegateLogFunction LogWarningFunction;
        public static DelegateLogFunction LogErrorFunction;

        public static void Log(string message)
        {
            if (LogFunction != null) LogFunction(message);
            else Debug.Log(message);
        }

        public static void LogWarning(string message)
        {
            if (LogWarningFunction != null) LogWarningFunction(message);
            else Debug.LogWarning(message);
        }

        public static void LogError(string message)
        {
            if (LogErrorFunction != null) LogErrorFunction(message);
            else Debug.LogError(message);
        }

        public static bool Assert(bool condition, string message)
        {
            if (!condition) LogError(message);
            return condition;
        }
    }
}