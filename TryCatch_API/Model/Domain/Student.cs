namespace TryCatch_API.Model.Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFatherName { get; set;}
        
        public int DepartmentId { get; set; }

        //Linking Student with 
        public Department Department { get; set; }
        

    }
}
