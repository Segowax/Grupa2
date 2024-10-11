// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata;

var a = new User();
a.name = "Mary";
a.surname = "Idk";
a.password = "password";
Console.WriteLine($"Name: \"{a.name}\", Surname: \"{a.surname}\", Password: \"{a.password}\"");

var b = new User();
b.name = a.name;
b.surname = "Nwm";
b.password = "passwordddddd";
Console.WriteLine($"Name: \"{b.name}\", Surname: \"{b.surname}\", Password: \"{b.password}\"");

public class User
{
    public string name { get; set; }
    public string surname { get; set; }
    public string password { get; set; }
}

