using System;
using System.Text;

namespace BH.Engine.Tensorflow
{
    public static partial class Query
    {
        public static string TypeName(Type type)
        {
            var nullableType = Nullable.GetUnderlyingType(type);
            if (nullableType != null)
            {
                return TypeName(nullableType) + "?";
            }

            if (type.IsByRef)
            {
                return "ref " + type.Name.Replace("&", "");
            }

            if (!type.IsGenericType)
            {
                if (type.IsArray)
                {
                    return TypeName(type.GetElementType()) + "[]";
                }

                //if (type.Si
                switch (type.Name)
                {
                    case "String": return "string";
                    case "Int16": return "short";
                    case "UInt16": return "ushort";
                    case "Int32": return "int";
                    case "UInt32": return "uint";
                    case "Int64": return "long";
                    case "UInt64": return "ulong";
                    case "Decimal": return "decimal";
                    case "Double": return "double";
                    case "Object": return "object";
                    case "Void": return "void";

                    default:
                        {
                            return string.IsNullOrWhiteSpace(type.FullName) ? type.Name : type.FullName;
                        }
                }
            }

            var sb = new StringBuilder(type.Name.Substring(0,
                type.Name.IndexOf('`'))
            );

            sb.Append('<');
            var first = true;
            foreach (var t in type.GetGenericArguments())
            {
                if (!first)
                    sb.Append(',');
                sb.Append(TypeName(t));
                first = false;
            }
            sb.Append('>');

            return sb.ToString();
        }
    }
}
