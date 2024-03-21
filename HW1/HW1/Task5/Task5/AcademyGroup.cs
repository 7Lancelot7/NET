using System.Text.Json;
using Task5.Contracts;

namespace Task5;

public class AcademyGroup : IAcademyGroup
{
    private List<Student> _listOfStudents;
    private int _count;


    public AcademyGroup()
    {
        _listOfStudents = new List<Student>();
        _count = 0;
    }

    public void Add(Student student)
    {
        if (student is null)
        {
            throw new NullReferenceException("Input param  is NULL");
        }

        _count++;
        _listOfStudents.Add(student);
    }

    public void Remove(string surname)
    {
        if (surname is null or "")
        {
            throw new NullReferenceException("Input param  is NULL or EMPTY");
        }

        var studentIndex = _listOfStudents.FindIndex(student1 => student1.Surname == surname);
        _listOfStudents.RemoveAt(studentIndex);
        _count--;
    }

    public void Edit(string surname, Student updatedStudent)
    {
        if (surname is null || surname == "" || updatedStudent == null)
        {
            throw new NullReferenceException("Input param  is NULL or EMPTY");
        }

        var student = _listOfStudents.Find(student1 => student1.Surname == surname);
        if (student is not null)
        {
            student.Surname = updatedStudent.Surname;
            student.Age = updatedStudent.Age;
            student.Name = updatedStudent.Name;
            student.Number_Of_Group = updatedStudent.Number_Of_Group;
            student.Phone = updatedStudent.Phone;
            student.Average = updatedStudent.Average;
        }
        else
        {
            throw new ArgumentException("Student with given surname not found");
        }
    }

    public void Print()
    {
        foreach (var student in _listOfStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}");
        }
    }

    public void Save(string filename)
    {
        string jsonString = JsonSerializer.Serialize(_listOfStudents);
        File.WriteAllText(filename, jsonString);
    }

    public void Load(string filename)
    {
        string jsonString = File.ReadAllText(filename);
        _listOfStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);
        _count = _listOfStudents.Count;
    }

    public Student Search(string surname)
    {
        var student = _listOfStudents.Find(st => st.Surname == surname);
        if (student is not null)
        {
            return student;
        }

        throw new ArgumentException("Student with given surname not found");
    }

    public Student Search(string name, string surname)
    {
        var student = _listOfStudents.Find(st => st.Surname == surname && st.Name == name);
        if (student is not null)
        {
            return student;
        }

        throw new ArgumentException("Student with given surname and name not found");
    }
}