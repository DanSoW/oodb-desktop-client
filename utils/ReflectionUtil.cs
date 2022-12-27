using oodb_desktop_client.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oodb_desktop_client.utils
{
    public class ReflectionUtil
    {
        public static List<object> getFields<T>(T element) where T : IdModel
        {
            List<object> fields = new List<object>();

            BindingFlags bindingFlags = BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.Static;

            fields.Add(element.Id);

            foreach (FieldInfo field in element.GetType().GetFields(bindingFlags))
            {
                fields.Add(field.GetValue(element));
            }

            return fields;
        }
    }
}
