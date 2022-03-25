using System;

namespace Lab2_Events
{
    public class AlarmEventArgs : EventArgs
    {
        public string InstituteName { get; set; }
        public string StudentName { get; }
        public string GroupName { get; }

        public AlarmEventArgs(string studentName, string groupName)
        {
            StudentName = studentName;
            GroupName = groupName;
        }

        public AlarmEventArgs(string studentName, string groupName, string instituteName)
        {
            StudentName = studentName;
            GroupName = groupName;
            InstituteName = instituteName;
        }
    }
}