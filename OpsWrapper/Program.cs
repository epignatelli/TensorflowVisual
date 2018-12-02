//#define OPS
//#define CTORS

using BH.Engine.Tensorflow;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpsWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
#if OPS
            string opsFolder = @"..\..\..\Tensorflow_Engine\AutoGenOps";
            List<MethodInfo> methods = BH.Engine.Tensorflow.Query.TensorflowOps();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Wrapping " + method.Name);
                Compute.WriteTFOperation(method, opsFolder);
            }
#endif

#if CTORS
            string ctorsFolder = @"..\..\..\Tensorflow_Engine\Create";
            List<ConstructorInfo> ctors = BH.Engine.Tensorflow.Query.TensorConstructors();
            Console.WriteLine("Wrapping TFTensor constructors");
            Compute.WriteTensorConstructors(ctors.ToArray(), ctorsFolder);
#endif


        }
    }
}
