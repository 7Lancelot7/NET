namespace Task5.Contracts;

public interface IAcademyGroup
{
    void Add(Student student);
    
    void Remove(string surname);
    
    void Edit(string surname, Student updatedStudent);
    
    void Print();
    
    void Save(string filename);
    
    void Load(string filename);
    
    Student Search(string surname);
}