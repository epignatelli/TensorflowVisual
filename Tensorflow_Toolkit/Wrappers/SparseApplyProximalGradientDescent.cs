using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseApplyProximalGradientDescent(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput alpha, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.SparseApplyProximalGradientDescent(var, alpha, l1, l2, grad, indices, use_locking, operName);
		}
	}
}
