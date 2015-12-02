using System;

// ReSharper disable once CheckNamespace
namespace uPLibrary.Networking.M2Mqtt
{
    public static class Fx
    {
        public static void SleepThread(int millisecondsTimeout)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public static void StartThread(Action threadStart)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }
    }
}
