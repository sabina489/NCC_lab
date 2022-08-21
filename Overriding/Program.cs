using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("This is parent class");
    }
}

class Tiger : Animal
{
    public override void Sound()
    {
        Console.WriteLine("hello world");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Tiger T = new Tiger();
        T.Sound();
    }
}
