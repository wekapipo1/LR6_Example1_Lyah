using System;

class Person
{
    //всього їжі
    public static double FoodQuantity = 100.0;
    //кількість людей
    public static int PeopleCount = 0;
    // поле вага людини
    double weight;
    //конструктор об'єкту
    public Person() 
    { weight = 10.0; PeopleCount++; }
    //властивість вага людини
    public double Weight 
    { get { return weight; } }
    //метод їсти
    public void ToEat()
    {
        //з'їдає 1 людина
        double t = FoodQuantity / 2.0 / PeopleCount;
        //вага людини збільшується
        weight += t;
        //кількість їжі зменшується
        FoodQuantity -= t;
    }
    public static string Description()
    {
        return String.Format("Людей - {0} Їжi - {1}", PeopleCount, FoodQuantity);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //створили об'єкт 1
        Person p1 = new Person();
        //вага людини
        Console.WriteLine("Вага людини1 - {0}", p1.Weight);
        //статичний метод
        //скільки залишилось їжі
        Console.WriteLine(Person.Description());
        //не статичний метод
        //людина поїла
        p1.ToEat();
        //вага людини
        Console.WriteLine("Вага людини1 - {0}", p1.Weight);
        //статичний метод
        //скільки залишилось їжі
        Console.WriteLine(Person.Description());
        //створили об'єкт 2
        Person p2 = new Person();
        //вага людини
        Console.WriteLine("Вага людини2 - {0}", p2.Weight);
        p2.ToEat();
        Console.WriteLine("Вага людини2 - {0}", p2.Weight);
        Console.WriteLine(Person.Description());
        Console.ReadKey();
    }
}
