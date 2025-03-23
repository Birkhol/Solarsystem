using System;
using System.Windows.Forms;


namespace SolarSystem_Graphics
{
    public class SimulationClock
    {
        System.Windows.Forms.Timer timer;
        public int Time { get; private set; } = 0;
        public double SpeedFactor { get; set; } = 1.0; // Default speed multiplier

        // Define the delegate and event that subscribers can listen to.
        public delegate void TickEventHandler(int time);
        public event TickEventHandler DoTick;

        public SimulationClock()
        {
            timer = new System.Windows.Forms.Timer { Interval = 50 };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increase time by the current speed factor.
            Time += (int)SpeedFactor;
            DoTick?.Invoke(Time);
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();
    }
}
