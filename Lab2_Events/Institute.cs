using System;
using System.Collections.Generic;

namespace Lab2_Events
{
    public abstract class Institute
    {
        public List<Student> Students { get; set; } = new();

        public abstract void MedicalCentreHandle(object sender, AlarmEventArgs args);
    }
}