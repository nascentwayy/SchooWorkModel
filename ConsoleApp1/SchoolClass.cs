using System.Collections.Generic;
public class School
{
    public string NameOfSchool;
    public List<Student> Students;

    public School(string nameOfSchool)
    {
        NameOfSchool = nameOfSchool;
        Students = new List<Student>();
    }

    public void PrintListOfStudents()
    {
        if (Students.Count == 0) Console.WriteLine("Список на данный момент пуст :(");
        else
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {Students[i].FirstName} {Students[i].LastName} {Students[i].Age}");
            }
        }
        
    }

    public void AddNewStudent(Student newStudent)
    {
        Students.Add(newStudent);
        Console.WriteLine($"Ученик {newStudent.FirstName} {newStudent.LastName} с возрастом {newStudent.Age} успешно добавлен в список школы!");
    }

    public void RemoveStudent(int numberStudent)
    {
        Students.RemoveAt(numberStudent - 1);
    }
}


