using System;
namespace CustomStopwatch
{
    public class Stopwatch
    {
        private static DateTime _start;
        private static DateTime _stop;
        private static DateTime _initialTime;
        private static bool _isRunning;
        public static bool GetIsRunning()
        {
            return _isRunning;
        }
        public static void Start()
        {
            _isRunning = true;
            _start = DateTime.Now;
            if (_initialTime.Equals(default(DateTime)))
            {
                _initialTime = _start;
            }

            Console.WriteLine("Start. Now is: " + _start);
            Console.WriteLine("The Stopwatch is running...");

        }
        public static void Stop()
        {
            _isRunning = false;
            _stop = DateTime.Now;
            Console.WriteLine("Stop. Now is: " + _stop);
        }
        public static string GetDuration()
        {
            _isRunning = false;
            var duration = _stop - _start;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", duration.Hours, duration.Minutes, duration.Seconds,
               duration.Milliseconds);
            return elapsedTime;
        }
        public static string GetTotalDuration()
        {
            _isRunning = false;
            var totalDuration = _stop - _initialTime;
            string totalElapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", totalDuration.Hours, totalDuration.Minutes, totalDuration.Seconds,
               totalDuration.Milliseconds);
            return totalElapsedTime;
        }
        public static void Reset()
        {
            _isRunning = false;
            _initialTime = default(DateTime);
            _start = default(DateTime);
            _stop = default(DateTime);
        }
    }
}
