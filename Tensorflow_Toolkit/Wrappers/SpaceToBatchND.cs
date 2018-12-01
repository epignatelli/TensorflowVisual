using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SpaceToBatchND(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput block_shape, TensorFlow.TFOutput paddings, string operName=null)
		{
			return graph.SpaceToBatchND(input, block_shape, paddings, operName);
		}
	}
}
