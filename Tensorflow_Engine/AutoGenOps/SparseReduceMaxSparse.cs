using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseReduceMaxSparse(this TFGraph graph, TensorFlow.TFOutput input_indices, TensorFlow.TFOutput input_values, TensorFlow.TFOutput input_shape, TensorFlow.TFOutput reduction_axes, System.Boolean? keep_dims=null, string operName=null)
		{
			return graph.SparseReduceMaxSparse(input_indices, input_values, input_shape, reduction_axes, keep_dims, operName);
		}
	}
}
