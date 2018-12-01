using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SpaceToBatch(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, long block_size, string operName=null)
		{
			return graph.SpaceToBatch(input, paddings, block_size, operName);
		}
	}
}
