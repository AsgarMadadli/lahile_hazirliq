using System;
using System.Collections.Generic;

public class Teacher
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }
    public List<Student> Students { get; set; }

    public Teacher(string name, int age, string subject)
    {
        Name = name;
        Age = age;
        Subject = subject;
        Students = new List<Student>();
    }

    public override string ToString()
    {
        return $"Teacher: {Name}, Age: {Age}, Subject: {Subject}";
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}