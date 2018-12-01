using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BH.Engine.DeepLearning
{
    public static partial class Query
    {
        public static List<MethodInfo> TensorflowOps()
        {
            return typeof(TensorFlow.TFGraph).GetMethods().ToList();
        }
    }
}
