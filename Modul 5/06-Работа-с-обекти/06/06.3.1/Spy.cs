using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06._3._1
{
    public class Spy
    {
        public string StealFieldInfo(string investigationClass, params string[] investigationFields)
        {
            Type classInfo = Type.GetType(investigationClass);

            FieldInfo[] fields = classInfo.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
            StringBuilder result = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classInfo, new object[] { });

            result.AppendLine($"Class under investigation: {investigationClass}");
            foreach (FieldInfo field in fields.Where(f => investigationFields.Contains(f.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return result.ToString().Trim();
        }
    }
}
