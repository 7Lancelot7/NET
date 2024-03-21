namespace Task5.Contracts;

public interface IPerson
{
    string Name { get; set; }
    
    string Surname { get; set; }
    
    int Age { get; set; }
    
    string Phone { get; set; }

     void  Print();
}