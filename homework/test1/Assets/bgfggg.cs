using System;
using System.Collections.Generic;
public class Student
{
    public int StudentId { get; set; }
    public Student(int studentId)
    {
        StudentId = studentId;
    }
}
class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 5;
        Dictionary<int, Student> students = new Dictionary<int, Student>();
        int studentId = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Student student = new Student(studentId);
                students.Add(studentId, student);
                studentId++;
            }
        }
        foreach (var student in students)
        {
            Console.WriteLine("Student Id: " + student.Value.StudentId);
        }
    }
}