using System.IO;
using System.Reflection;

namespace BH.Engine.DeepLearning
{
    public static partial class Compute
    {
        public static bool WriteTFOperation(MethodInfo method, string outFolder)
        {
            if (method.ReturnType == typeof(void))
            {
                return false;
            }

            string methodString = method.OpWrapper();
            try
            {
                string path = Path.Combine(outFolder, method.Name + ".cs");
                File.WriteAllText(path, methodString);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
