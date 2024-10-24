using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;

namespace PatientMonitor
{
    class ECG
    {
        // Variablen 
        private double amplitude = 0.0;
        private double frequency = 0;

        //Probities 
        public double Amplitude
        {
            get { return amplitude; }
            set
            {
                if (value < 10)
                    amplitude = value;
            }
        }

        public double Ftrequency { get => frequency; set => frequency = value; }



            

        public ECG(double amplitude, double frequency)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
        }

        public double NextSample(double timeIndex)
        {
            const double HzToBeatsPerMin = 60.0;
            double sample;

            sample = Math.Cos(2 * Math.PI * (frequency / HzToBeatsPerMin) * timeIndex);
            sample *= amplitude;
            return (sample);
        }
    }
}

