using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace String_Intern.Classes
{
    public class TimerClass
    {
        private double _timeElapsed;
        private System.Timers.Timer _timer;

        public double TimeElapsed
        {
            get { return _timeElapsed; }
        }

        public TimerClass()
        {
            _timeElapsed = 0;
            _timer = new System.Timers.Timer(100);
        }

        public void Start()
        {
            SetTimer();
        }

        public void Stop()
        {
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Stop();
            _timeElapsed = 0;
        }


        private void SetTimer()
        {
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _timeElapsed += 0.1;
        }
    }
}
