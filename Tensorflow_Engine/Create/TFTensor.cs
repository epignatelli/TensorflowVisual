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
        public static TFTensor Input(int[] array)
        {
            return new TFTensor(array);
        }

        public static TFTensor Input(int data)
        {
            return new TFTensor(data);
        }
    }
}
