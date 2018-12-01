using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> SparseAddGrad(TFGraph graph, TensorFlow.TFOutput backprop_val_grad, TensorFlow.TFOutput a_indices, TensorFlow.TFOutput b_indices, TensorFlow.TFOutput sum_indices, string operName=null)
		{
			return graph.SparseAddGrad(backprop_val_grad, a_indices, b_indices, sum_indices, operName);
		}
	}
}
