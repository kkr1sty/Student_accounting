using System.Xml.Linq;

Console.WriteLine($"Система учета студентов\nНачальное количество студентов:{Student.InstanceCount}");

var student1 = new Student("Никита", "Властелин колец","Толкин");
student1.Print_student();

var student2 = new Student("Владимир", "Хобит", "Дж.дж.Толкин");
student2.Print_student();

Book bookCopy = student1.FavoriteBook;
bookCopy.name = "Властелин колец";


Book book = new();
struct Book
{
    public string name;
    public string author;
}
class Student
{
    public string Name { get; set; }
    public static int InstanceCount { get; private set; }

    public Book FavoriteBook; 

    public Student(string name, string bookName, string bookAuthor)
    {
        Name = name;

        FavoriteBook.name = bookName;
        FavoriteBook.author = bookAuthor;


        InstanceCount++;
    }


    public void Print_student()
    {
        Console.WriteLine($"Создан студент {Name}\nТекущее количество студентов:{InstanceCount}");

    }
}
