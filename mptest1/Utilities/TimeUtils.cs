using System.Diagnostics;

namespace mptest1
{
    public class TimeUtils
    {
        public static void Waitfor(int timeperiod)
        {
            Stopwatch sw = new Stopwatch(); // sw cotructor
            sw.Start(); // starts the stopwatch
            for (int i = 0;; i++)
            {
                if (i%100000 == 0) // if in 100000th iteration (could be any other large number
                    // depending on how often you want the time to be checked) 
                {
                    sw.Stop(); // stop the time measurement
                    if (sw.ElapsedMilliseconds > timeperiod) // check if desired period of time has elapsed
                    {
                        break; 
                    }
                    else
                    {
                        sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
                        // and resume time measurement
                    }
                }
            }
        }
    }
}