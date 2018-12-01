using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BH.Engine.Tensorflow;

namespace OpsWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string outFolder = @"E:\02. Research\01. GitHub\BuroHappoldEngineering\Tensorflow_Toolkit\Tensorflow_Engine\Wrappers";
            List<MethodInfo> methods = BH.Engine.Tensorflow.Query.TensorflowOps();
            foreach( MethodInfo method in methods)
            {
                Console.WriteLine("Wrapping " + method.Name);
                Compute.WriteTFOperation(method, outFolder);
            }
        }
    }
}
