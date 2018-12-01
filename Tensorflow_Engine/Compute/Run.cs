using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
    public static partial class Compute
    {
        public static TFTensor[] Run(this TFGraph graph, TFOutput[] inputNodes, TFTensor[] inputValue, TFOutput[] outputNode)
        {
            using (TFSession sess = new TFSession(graph))
            {
                return sess.Run(inputNodes, inputValue, outputNode);
            }
        }

        public static TFTensor[] Run(this TFGraph graph, TFOutput inputNodes, TFTensor inputValue, TFOutput outputNode)
        {
            using (TFSession sess = new TFSession(graph))
            {
                return sess.Run(new TFOutput[] { inputNodes }, new TFTensor[] { inputValue }, new TFOutput[] { outputNode });
            }
        }
    }
}
