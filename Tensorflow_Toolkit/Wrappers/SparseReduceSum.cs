using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseReduceSum(TFGraph graph, TensorFlow.TFOutput input_indices, TensorFlow.TFOutput input_values, TensorFlow.TFOutput input_shape, TensorFlow.TFOutput reduction_axes, System.Boolean? keep_dims=null, string operName=null)
		{
			return graph.SparseReduceSum(input_indices, input_values, input_shape, reduction_axes, keep_dims, operName);
		}
	}
}
