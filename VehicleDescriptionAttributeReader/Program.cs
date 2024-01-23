using System;
using AttributeCarLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ReflectOnAttributesUsingEarlyBinding();
        Console.ReadLine();
    }

    private static void ReflectOnAttributesUsingEarlyBinding()
    {
        Type t = typeof(Winnebago);
        object[] customAll = t.GetCustomAttributes(false);
        foreach (object custom in customAll)
        {
            Console.WriteLine(custom.ToString());
        }
    }
}