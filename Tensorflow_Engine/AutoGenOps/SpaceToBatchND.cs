using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SpaceToBatchND(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput block_shape, TensorFlow.TFOutput paddings, string operName=null)
		{
			return graph.SpaceToBatchND(input, block_shape, paddings, operName);
		}
	}
}
