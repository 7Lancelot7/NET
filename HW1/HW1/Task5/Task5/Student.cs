namespace Task5;

public class Student : Person
{
    private double _average;
    private string _numberOfGroup;

    
    public double Average
    {
        get => _average;
        set => _average = value;
    }

    public string Number_Of_Group
    {
        get => _numberOfGroup;
        set => _numberOfGroup = value;
    }

    public Student()
    {
        
    }
    public Student(string name, string surname, int age, string phone, double average, string number_of_group)
        : base(name, surname, age, phone)
    {
        _average = average;
        _numberOfGroup = number_of_group;
    }

    public Student(string name, string surname, int age, double average, string number_of_group)
        : base(name, surname, age, "xxx")
    {
        _average = average;
        _numberOfGroup = number_of_group;
    }

    public override void Print()
    {
        string json =
            $"{{ \"Name\": \"{Name}\", \"Surname\": \"{Surname}\", \"Age\": {Age}, \"Phone\": \"{Phone}\", \"Average\": {Average}, \"Number_Of_Group\": {Number_Of_Group} }}";
        Console.WriteLine(json);
    }
}