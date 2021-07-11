using System;
namespace CustomStopwatch
{
    public class Stopwatch
    {
        private static DateTime _start;
        private static DateTime _stop;
        private static DateTime initialTime;
        private static bool hasStarted = false;
        private static bool hasStopped = true;
        public static bool HasStarted
        {
            get
            {
                return hasStarted;
            }
        }
        public static bool HasStopped
        {
            get
            {
                return hasStopped;
            }
        }

        public static void Start()
        {
            hasStarted = true;
            hasStopped = false;
            _start = DateTime.Now;
            if (initialTime.Equals(default(DateTime)))
            {
                initialTime = _start;
            }

            Console.WriteLine("Start. Now is: " + _start);
            Console.WriteLine("The Stopwatch is counting...");

        }
        public static void Stop()
        {

            if (_start == null && !hasStarted)
            {
                Console.WriteLine("The Stopwatch hasn\'t started yet");
                Console.WriteLine("Please follow above guidelines to use the stopwatch");
                return;
            }
            hasStarted = false;
            hasStopped = true;
            _stop = DateTime.Now;
            Console.WriteLine("Stop. Now is: " + _stop);
        }
        public static string GetDuration()
        {
            hasStarted = false;
            hasStopped = true;
            var duration = _stop - _start;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", duration.Hours, duration.Minutes, duration.Seconds,
               duration.Milliseconds);
            return elapsedTime;
        }
        public static string GetTotalDuration()
        {
            hasStarted = false;
            hasStopped = true;
            var totalDuration = _stop - initialTime;
            string totalElapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", totalDuration.Hours, totalDuration.Minutes, totalDuration.Seconds,
               totalDuration.Milliseconds);
            return totalElapsedTime;
        }
        public static void Reset()
        {
            hasStarted = false;
            hasStopped = true;
            initialTime = default(DateTime);
            _start = default(DateTime);
            _stop = default(DateTime);
        }
    }
}
