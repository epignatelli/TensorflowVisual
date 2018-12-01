using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SpaceToBatch(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, long block_size, string operName=null)
		{
			return graph.SpaceToBatch(input, paddings, block_size, operName);
		}
	}
}
