using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class
| AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
AllowMultiple = false)]

public class VersionAttribute : System.Attribute
{
    public double Version { get; private set; }
    public string Name { get; private set; }

    public VersionAttribute(double version, string name)
    {
        this.Version = version;
        this.Name = name;
    }
}


[Version(1.6, "ClassTest")]
public class ClassTest
{

    [Version(1.1, "TestStruct")]
    public struct TestStruct
    {
    }


    [Version(2.3, "TestEnum")]
    public enum TestEnum
    {
    }

    static void Main()
    {
        Type type = typeof(ClassTest);
        Type typeEnum = typeof(TestEnum);
        Type typeStruct = typeof(TestStruct);

        object[] allAttributes =
            type.GetCustomAttributes(false);
        foreach (VersionAttribute attr in allAttributes)
        {
            Console.WriteLine("{0} version is: {1}",attr.Name, attr.Version);
        }

        object[] allTypeEnum =
            typeEnum.GetCustomAttributes(false);
        foreach (VersionAttribute attr in allTypeEnum)
        {
            Console.WriteLine("{0} version is: {1}", attr.Name, attr.Version);
        }

        object[] allTypeStruct =
            typeStruct.GetCustomAttributes(false);
        foreach (VersionAttribute attr in allTypeStruct)
        {
            Console.WriteLine("{0} version is: {1}", attr.Name, attr.Version);
        }
    }
}