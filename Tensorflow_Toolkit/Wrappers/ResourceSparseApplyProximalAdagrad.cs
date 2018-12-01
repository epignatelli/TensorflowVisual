using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceSparseApplyProximalAdagrad(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceSparseApplyProximalAdagrad(var, accum, lr, l1, l2, grad, indices, use_locking, operName);
		}
	}
}
