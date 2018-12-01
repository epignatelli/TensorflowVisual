using System.Reflection;
using System.Text;

namespace BH.Engine.Tensorflow
{
    public static partial class Convert
    {
        public static string OpWrapper(this MethodInfo method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            StringBuilder sb = new StringBuilder();

            //Usings
            sb.AppendLine("using System;");
            sb.AppendLine("using TensorFlow;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("");

            // Context
            sb.AppendLine("namespace BH.Engine.Tensorflow");
            sb.AppendLine("{");
            sb.AppendLine("public static partial class Compute");
            sb.AppendLine("\t{");

            // Signature
            string signature = "\t\tpublic static " + Query.TypeName(method.ReturnType) + " " + method.Name + "(this TFGraph graph, ";

            foreach (ParameterInfo par in parameters)
            {
                signature += (Query.TypeName(par.ParameterType) + " " + par.Name);
                if (par.HasDefaultValue)
                {
                    signature += ("=" + par.DefaultValueAsString()); // `par.DefaultValue ?? null` weirdly does not work
                }
                signature += (", ");
            }

            signature = signature.Substring(0, signature.Length - 2);
            signature += (")");
            sb.AppendLine(signature);

            // Corpus
            sb.AppendLine("\t\t{");
            string corpus = "\t\t\treturn graph." + method.Name + "(";


            foreach (ParameterInfo par in parameters)
            {
                if (par.ParameterType.IsByRef)
                {
                    corpus += "ref ";
                }
                corpus += (par.Name + ", ");
            }

            if (parameters.Length > 0)
            {
                corpus = corpus.Substring(0, corpus.Length - 2);
            }
            corpus += (");");
            sb.AppendLine(corpus);

            // Closing
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
