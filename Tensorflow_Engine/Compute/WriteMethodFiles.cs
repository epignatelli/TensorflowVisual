using System.IO;
using System.Reflection;
using System.Text;

namespace BH.Engine.Tensorflow
{
    public static partial class Compute
    {
        public static bool WriteTFOperation(MethodInfo method, string outFolder)
        {
            if (method.ReturnType == typeof(void)) // skip internals
            {
                return false;
            }
            if (method.Name.Contains("_get")) // skip accessors
            {
                return false;
            }

            string methodString = method.WrappedOp();
            try
            {
                string path = Path.Combine(outFolder, method.Name + ".ag.cs");
                File.WriteAllText(path, methodString);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool WriteTensorConstructors(ConstructorInfo[] ctors, string outFolder)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using TensorFlow;");
            sb.AppendLine();
            sb.AppendLine("namespace BH.Engine.Tensorflow");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class Create");
            sb.AppendLine("\t{");

            foreach(ConstructorInfo ctor in ctors)
            {
                sb.AppendLine("\t\t" + ctor.WrappedTensorConstructor());
                sb.AppendLine("\t\t");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");


            try
            {
                string path = Path.Combine(outFolder, "TFTensor.ag.cs");
                File.WriteAllText(path, sb.ToString());
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
