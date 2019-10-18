using System;
using System.Globalization;

namespace Test
{
    public class Stopwatch
    {

       
        public DateTime _start;
        public DateTime _stop;
    
        public void Start()
        {
            if (_start > _stop)
            {
                throw new ArgumentException("StopWatch is already running");
            }

            _start = DateTime.Now;

        }

        public TimeSpan Stop()
        {
            if (_start < _stop)
            {
                throw new System.InvalidOperationException("StopWatch has stopped");
            }
            _stop = DateTime.Now;
            var _duration = _stop - _start;
            var durations = _duration.TotalSeconds.ToString();
             
            return _duration;
        }


    }
}