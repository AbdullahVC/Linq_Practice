using System;
using System.Collections.Generic;
using System.Linq;

// Öğrenciler tablosunu temsil eden sınıf
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int ClassId { get; set; }
}

// Sınıflar tablosunu temsil eden sınıf
public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}

class Program
{
    static void Main()
    {
        // Öğrenciler listesi oluşturuluyor
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 1 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 2 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 2 },
            new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 3 }
        };

        // Sınıflar listesi oluşturuluyor
        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

        // LINQ group join ile öğrencileri sınıflarına göre gruplama
        var classWithStudents = from c in classes
                                join s in students
                                on c.ClassId equals s.ClassId into studentGroup
                                select new { c.ClassName, Students = studentGroup };

        // Sonuçları ekrana yazdırıyoruz
        Console.WriteLine("Sınıflar ve Öğrenciler:");
        foreach (var group in classWithStudents)
        {
            Console.WriteLine($"\nSınıf: {group.ClassName}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($"- Öğrenci: {student.StudentName}");
            }
        }
    }
}
