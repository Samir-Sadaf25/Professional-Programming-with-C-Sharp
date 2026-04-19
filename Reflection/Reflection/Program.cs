
using Reflection;
using System.Reflection;

Type t = typeof(Camera);
ConstructorInfo[] constructors = t.GetConstructors();
foreach(ConstructorInfo constructor in constructors)
{
    ParameterInfo[] parameters = constructor.GetParameters();
    foreach (ParameterInfo parameter in parameters)
    {
        Console.WriteLine($"{parameter.ParameterType.Name} - {parameter.Name}");
    }
    object camera = constructor.Invoke(["abc-222", 32]);
    MethodInfo method = t.GetMethod("take picture");
    method.Invoke(camera,null);
}