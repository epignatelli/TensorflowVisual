using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseToSparseSetOperation(this TFGraph graph, TensorFlow.TFOutput set1_indices, TensorFlow.TFOutput set1_values, TensorFlow.TFOutput set1_shape, TensorFlow.TFOutput set2_indices, TensorFlow.TFOutput set2_values, TensorFlow.TFOutput set2_shape, string set_operation, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.SparseToSparseSetOperation(set1_indices, set1_values, set1_shape, set2_indices, set2_values, set2_shape, set_operation, validate_indices, operName);
		}
	}
}
