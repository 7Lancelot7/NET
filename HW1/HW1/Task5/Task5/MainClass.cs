namespace Task5;

public class MainClass
{
    public static void Main()
    {
        try
        {
            // Создаем экземпляр класса AcademyGroup
            AcademyGroup group = new AcademyGroup();
            group.Load("students.json");
            group.Print();
            // // Добавляем студентов
            // group.Add(new Student("John", "Doe", 25, "1234567890", 3.5, "KS"));
            // group.Add(new Student("Alice", "Smith", 22, "9876543210", 4.0, "102"));


            // // Выводим информацию о студентах
            // group.Print();
            //
            // // Сохраняем данные в файл
            // group.Save("students.json");
            //
            // // Загружаем данные из файла
            // group.Load("students.json");
            //
            // // Ищем студента по фамилии
            // Student foundStudent = group.Search("Doe");
            //
            // // Выводим информацию о найденном студенте
            // Console.WriteLine($"Found student: {foundStudent.Name} {foundStudent.Surname}");
            //
            // // Ищем студента по имени и фамилии
            // foundStudent = group.Search("Alice", "Smith");
            //
            // // Выводим информацию о найденном студенте
            // Console.WriteLine($"Found student: {foundStudent.Name} {foundStudent.Surname}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}