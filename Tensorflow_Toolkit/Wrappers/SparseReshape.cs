using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseReshape(TFGraph graph, TensorFlow.TFOutput input_indices, TensorFlow.TFOutput input_shape, TensorFlow.TFOutput new_shape, string operName=null)
		{
			return graph.SparseReshape(input_indices, input_shape, new_shape, operName);
		}
	}
}
