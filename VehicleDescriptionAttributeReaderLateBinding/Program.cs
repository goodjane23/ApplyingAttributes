
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ReflectAttributesUsingLateBinding();
        Console.ReadLine();
    }

    private static void ReflectAttributesUsingLateBinding()
    {
        try
        {
            Assembly asm = Assembly.LoadFrom("AttributeCarLibrary");
            Type vehicleDesc = asm.GetType("AttributeCarLibrary.VehicleDescriptionAttribute");
            PropertyInfo propertyInfo = vehicleDesc.GetProperty("Description");
            Type[] types = asm.GetTypes();
            foreach (Type type in types)
            {
                object[] objects = type.GetCustomAttributes(vehicleDesc,false);
                foreach (var o in objects)
                {
                    Console.WriteLine($"{type.Name}: {propertyInfo.GetValue(o,null)}");
                }
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}