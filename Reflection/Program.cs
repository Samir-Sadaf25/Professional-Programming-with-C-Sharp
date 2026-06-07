//using Reflection;
//using System;
//using System.Reflection;
//using System.Text.Json;

//Type personType = typeof(Person);
////Console.WriteLine(personType.FullName);

////Console.WriteLine("Properties");
//foreach (PropertyInfo property in personType.GetProperties())
//{
//   // Console.WriteLine("- " + property.Name + " (" + property.PropertyType.Name + ")");
//}
////Console.WriteLine("Methods:");
////foreach (MethodInfo method in personType.GetMethods())
////{
////    Console.WriteLine("- " + method.Name);
////}

//Type animalType = typeof(Animal);
//object animalInstance = Activator.CreateInstance(animalType);

//PropertyInfo speciesProperty = animalType.GetProperty("Species");
//PropertyInfo legsProperty = animalType.GetProperty("Legs");

//speciesProperty.SetValue(animalInstance, "Dog");
//legsProperty.SetValue(animalInstance, 4);

////foreach (PropertyInfo prop in animalType.GetProperties())
////{
////    Console.WriteLine(prop.Name);
////}

//MethodInfo methodInfo = animalType.GetMethod("Describe");
//Console.WriteLine(methodInfo);

//ConstructorInfo constructorInfo = animalType.GetConstructor(new Type[] {});
////Console.WriteLine(constructorInfo);

//PropertyInfo propertyInfo = animalType.GetProperty("Legs");
//PropertyInfo propertyInfo1 = animalType.GetProperty("Species");




//// create instance of a class
//object o = constructorInfo.Invoke(new object[] {});
//propertyInfo.SetValue(o, 4);
//propertyInfo1.SetValue(o, "Dog");
//object result = methodInfo.Invoke(o, null);
//Console.WriteLine(result);

using System;
using System.Reflection;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class ReflectionSerializer
{
    public static string SerializeToJson(object obj)
    {
        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();
        string json = "{ ";

        foreach (var prop in properties)
        {
            string name = prop.Name;
            string value = prop.GetValue(obj)?.ToString() ?? "null";
            json += $"\"{name}\": \"{value}\", ";
        }

        json = json.TrimEnd(',', ' ') + " }";
        return json;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "Alice", Age = 30 };
        string json = ReflectionSerializer.SerializeToJson(person);
        Console.WriteLine(json);
    }
}