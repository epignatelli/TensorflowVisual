using System.Reflection;
using System.Text;

namespace BH.Engine.DeepLearning
{
    public static partial class Convert
    {
        public static string OpWrapper(this MethodInfo method)
        {
            StringBuilder sb = new StringBuilder();

            //Usings
            sb.AppendLine("using System;");
            sb.AppendLine("using TensorFlow;");
            sb.AppendLine("");

            // Context
            sb.AppendLine("namespace BH.Engine.Deeplearning");
            sb.AppendLine("{");
            sb.AppendLine("public static partial class Compute");
            sb.AppendLine("\t{");

            // Signature
            string signature = "\t\tpublic static " + Query.TypeName(method.ReturnType) + " " + method.Name + "(this TFGraph graph, ";

            foreach (ParameterInfo par in method.GetParameters())
            {
                signature += (Query.TypeName(par.ParameterType) + " " + par.Name);
                if (par.HasDefaultValue)
                {
                    signature += ("=" + (par.DefaultValue == null ? "null" : par.DefaultValue)); // `par.DefaultValue ?? null` weirdly does not work
                }
                signature += (", ");
            }
            signature = signature.Substring(0, signature.Length - 2);
            signature += (")");
            sb.AppendLine(signature);

            // Corpus
            sb.AppendLine("\t\t{");
            string corpus = "\t\t\treturn graph." + method.Name + "(";

            foreach (ParameterInfo par in method.GetParameters())
            {
                corpus += (par.Name + ", ");
            }

            corpus = corpus.Substring(0, corpus.Length - 2);
            corpus += (");");
            sb.AppendLine(corpus);

            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
