using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BH.Engine.Tensorflow
{
    public static partial class Query
    {
        public static List<MethodInfo> TensorflowOps()
        {
            return typeof(TensorFlow.TFGraph).GetMethods().ToList();
        }

        public static List<ConstructorInfo> TensorConstructors()
        {
            return typeof(TensorFlow.TFTensor).GetConstructors().ToList();
        }
    }
}
