namespace Lab2_Events
{
    public class Vii : Institute
    {
        public Vii()
        {
            Students.Add(new Student(){ Name = "A", GroupName = "VI21-20B"});
            Students.Add(new Student(){ Name = "B", GroupName = "VI21-20B"});
            Students.Add(new Student(){ Name = "C", GroupName = "VI21-20B"});
            Students.Add(new Student(){ Name = "D", GroupName = "VI21-21B"});
            Students.Add(new Student(){ Name = "E", GroupName = "VI21-21B"});
            Students.Add(new Student(){ Name = "F", GroupName = "VI21-21B"});
            Students.Add(new Student(){ Name = "G", GroupName = "VI21-22B"});
            Students.Add(new Student(){ Name = "H", GroupName = "VI21-22B"});
            Students.Add(new Student(){ Name = "A", GroupName = "VI21-22B"});
        }
        
        public override void MedicalCentreHandle(object sender, AlarmEventArgs args)
        {
            if (args.InstituteName == "Vii")
            {
                foreach (Student student in Students)
                {
                    student.IsStudyDistance = true;
                }
            }
        }
    }
}