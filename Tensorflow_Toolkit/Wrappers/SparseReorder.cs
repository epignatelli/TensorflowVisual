using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseReorder(TFGraph graph, TensorFlow.TFOutput input_indices, TensorFlow.TFOutput input_values, TensorFlow.TFOutput input_shape, string operName=null)
		{
			return graph.SparseReorder(input_indices, input_values, input_shape, operName);
		}
	}
}
