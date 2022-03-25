namespace Lab2_Events
{
    public class Gi : Institute
    {
        public Gi()
        {
            Students.Add(new Student(){ Name = "A", GroupName = "GI21-20B"});
            Students.Add(new Student(){ Name = "B", GroupName = "GI21-20B"});
            Students.Add(new Student(){ Name = "C", GroupName = "GI21-20B"});
            Students.Add(new Student(){ Name = "D", GroupName = "GI21-21B"});
            Students.Add(new Student(){ Name = "E", GroupName = "GI21-21B"});
            Students.Add(new Student(){ Name = "F", GroupName = "GI21-21B"});
            Students.Add(new Student(){ Name = "G", GroupName = "GI21-22B"});
            Students.Add(new Student(){ Name = "H", GroupName = "GI21-22B"});
            Students.Add(new Student(){ Name = "A", GroupName = "GI21-22B"});
        }
        
        public override void MedicalCentreHandle(object sender, AlarmEventArgs args)
        {
            if (args.InstituteName == "Gi")
            {
                foreach (Student student in Students)
                {
                    if (student.Name == args.StudentName)
                    {
                        student.IsStudyDistance = true;
                        break;
                    }
                }
            }
        }
    }
}