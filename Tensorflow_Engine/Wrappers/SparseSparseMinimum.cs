using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseSparseMinimum(this TFGraph graph, TensorFlow.TFOutput a_indices, TensorFlow.TFOutput a_values, TensorFlow.TFOutput a_shape, TensorFlow.TFOutput b_indices, TensorFlow.TFOutput b_values, TensorFlow.TFOutput b_shape, string operName=null)
		{
			return graph.SparseSparseMinimum(a_indices, a_values, a_shape, b_indices, b_values, b_shape, operName);
		}
	}
}
