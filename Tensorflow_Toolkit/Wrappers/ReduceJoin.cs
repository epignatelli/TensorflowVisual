using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReduceJoin(TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput reduction_indices, System.Boolean? keep_dims=null, string separator=null, string operName=null)
		{
			return graph.ReduceJoin(inputs, reduction_indices, keep_dims, separator, operName);
		}
	}
}
