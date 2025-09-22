using System;

public class Panda
{
    public string Name { get; set; }

    public Panda(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Panda myPanda = new Panda("Rachel");
        Console.WriteLine("The panda's name is " + myPanda.Name);
    }
}

