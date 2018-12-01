using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
    public static partial class Create
    {
        public static TFShape Input(IEnumerable<long> shape)
        {
            return new TFShape(shape.ToArray());
        }
    }
}
