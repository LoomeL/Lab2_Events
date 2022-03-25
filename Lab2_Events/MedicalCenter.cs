using System;
using System.Collections.Generic;

namespace Lab2_Events
{
    public sealed class MedicalCenter
    {
        private List<Institute> Institutes = new();
        public event AlarmHandler Alarm;
        public delegate void AlarmHandler(object sendler, AlarmEventArgs args);
        
        public MedicalCenter()
        {
            Institutes.Add(new Ikit());
            Institutes.Add(new Vii());
            Institutes.Add(new Gi());
            
            foreach (Institute institute in Institutes)
            {
                Alarm += institute.MedicalCentreHandle;
            }
            
            OnAlarm(new AlarmEventArgs("D", "KI21-20B"));
        }

        private void OnAlarm(AlarmEventArgs args)
        {
            Alarm?.Invoke(this, args);
        }
    }
}