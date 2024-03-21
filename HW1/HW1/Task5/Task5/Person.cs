using Task5.Contracts;

namespace Task5;

public class Person : IPerson
{
    private string _name;
    private string _surname;
    private int _age;
    private string _phone;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public Person(string name, string surname, int age, string phone)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _phone = phone;
    }

    public Person(string name, string surname, int age)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _phone = "xxx";
    }

    protected Person()
    {
        
    }
    public virtual void Print()
    {
        string json = $"{{ \"Name\": \"{Name}\", \"Surname\": \"{Surname}\", \"Age\": {Age}, \"Phone\": \"{Phone}\" }}";
        Console.WriteLine(json);
    }

}