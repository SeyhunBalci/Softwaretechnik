using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    public class Patient

        

    {
        ECG ecg;


        public double ECGAmplitude {  set => ecg.Amplitude = value; }
        public double ECGFrequency {  set => ecg.Ftrequency = value; }

        public Patient(double amplitede, double frequency)
        {
            ecg = new ECG(amplitede, frequency);
        }
        public double NextSample(double timeIndex)
        {
            return ecg.NextSample(timeIndex);
        }

    }
}
