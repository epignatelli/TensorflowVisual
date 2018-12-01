using System.Reflection;

namespace BH.Engine.Tensorflow
{
    public static partial class Query
    {
        public static string DefaultValueAsString(this ParameterInfo p)
        {
            // Make sure p has default value
            object dValue = p.DefaultValue;

            if (dValue == null)
            {
                return "null";
            }

            if (p.DefaultValue is bool || p.DefaultValue is System.Boolean?)
            {
                return dValue.ToString().ToLower();
            }

            if (p.ParameterType.IsEnum)
            {
                return dValue.ToString().Insert(0, p.ParameterType + ".");
            }

            else
            {
                return p.DefaultValue.ToString();
            }
        }
    }
}
