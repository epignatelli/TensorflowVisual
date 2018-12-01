using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseReduceSumSparse(this TFGraph graph, TensorFlow.TFOutput input_indices, TensorFlow.TFOutput input_values, TensorFlow.TFOutput input_shape, TensorFlow.TFOutput reduction_axes, System.Boolean? keep_dims=null, string operName=null)
		{
			return graph.SparseReduceSumSparse(input_indices, input_values, input_shape, reduction_axes, keep_dims, operName);
		}
	}
}
