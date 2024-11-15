using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        var a = new User();
        var b = new User();

        a.Name = "Agnieszka";
        b.Nazwisko = "Kolodziej";

        a = b;
        Console.WriteLine($"Name; {a.Name} Nazwisko: {b.Nazwisko}");
    }

    class User
    {
        public string? Name { get; set; }
        public string? Nazwisko { get; set; }
    }
}
