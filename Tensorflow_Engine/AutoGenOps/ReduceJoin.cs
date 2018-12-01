using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReduceJoin(this TFGraph graph, TensorFlow.TFOutput inputs, TensorFlow.TFOutput reduction_indices, System.Boolean? keep_dims=null, string separator=null, string operName=null)
		{
			return graph.ReduceJoin(inputs, reduction_indices, keep_dims, separator, operName);
		}
	}
}
