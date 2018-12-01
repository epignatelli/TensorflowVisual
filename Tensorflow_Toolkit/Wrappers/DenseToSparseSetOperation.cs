using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> DenseToSparseSetOperation(TFGraph graph, TensorFlow.TFOutput set1, TensorFlow.TFOutput set2_indices, TensorFlow.TFOutput set2_values, TensorFlow.TFOutput set2_shape, string set_operation, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.DenseToSparseSetOperation(set1, set2_indices, set2_values, set2_shape, set_operation, validate_indices, operName);
		}
	}
}
