namespace Lesson4.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public int ClassId{ get; set; }
        public Student()
        {
        }
        public Student(int id, string name,int age,int classId)   
        {
            Id = id;
            Age = age;
            Name = name;
            ClassId = classId;
        }

    }
}
