using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
    public static partial class Query
    {
        public static object Value(TFTensor tensor)
        {
            return tensor.GetValue();
        }

        public static List<object> Value(TFTensor[] tensor)
        {
            return tensor.Select(t => t.GetValue()).ToList();
        }
    }
}
