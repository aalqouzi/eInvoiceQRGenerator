using System;

namespace ZatcaQRUtility
{
    public class Helper
    {
        /// <summary>
        /// Convert DateTime.Now to a timestamp as double
        /// </summary>
        /// <returns>TimeStamp as double</returns>
        public static double GetTimeStamp()
        {
            TimeSpan epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
            TimeSpan unixTicks = new TimeSpan(DateTime.UtcNow.Ticks) - epochTicks;
            double unixTime = unixTicks.TotalSeconds;
            return unixTime;
        }
    }
}
