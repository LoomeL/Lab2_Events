namespace Lab2_Events
{
    public class Ikit : Institute
    {
        public Ikit()
        {
            
            Students.Add(new Student(){ Name = "A", GroupName = "KI21-20B"});
            Students.Add(new Student(){ Name = "B", GroupName = "KI21-20B"});
            Students.Add(new Student(){ Name = "C", GroupName = "KI21-20B"});
            Students.Add(new Student(){ Name = "D", GroupName = "KI21-21B"});
            Students.Add(new Student(){ Name = "E", GroupName = "KI21-21B"});
            Students.Add(new Student(){ Name = "F", GroupName = "KI21-21B"});
            Students.Add(new Student(){ Name = "G", GroupName = "KI21-22B"});
            Students.Add(new Student(){ Name = "H", GroupName = "KI21-22B"});
            Students.Add(new Student(){ Name = "A", GroupName = "KI21-22B"});
        }
        
        public override void MedicalCentreHandle(object sender, AlarmEventArgs args)
        {
            if (args.InstituteName == "Ikit")
            {
                foreach (Student student in Students)
                {
                    if (student.GroupName == args.GroupName) student.IsStudyDistance = true;
                }
            }
        }
    }
}