using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06._3._2
{
    internal class Spy
    {
        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder result = new StringBuilder();

            Type classType = Type.GetType(className);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);


            foreach (FieldInfo field in fields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Public |BindingFlags.Instance| BindingFlags.Static | BindingFlags.NonPublic);
            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get") && !m.IsPublic))
            {
                result.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set") && m.IsPublic))
            {
                result.AppendLine($"{method.Name} have to be private!");
            }
            return result.ToString();
        }
    }
}
