using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Any(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput reduction_indices, System.Boolean? keep_dims=null, string operName=null)
		{
			return graph.Any(input, reduction_indices, keep_dims, operName);
		}
	}
}
