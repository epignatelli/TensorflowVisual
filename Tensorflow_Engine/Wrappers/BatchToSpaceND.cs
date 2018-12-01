using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BatchToSpaceND(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput block_shape, TensorFlow.TFOutput crops, string operName=null)
		{
			return graph.BatchToSpaceND(input, block_shape, crops, operName);
		}
	}
}
