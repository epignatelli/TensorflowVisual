using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceSparseApplyFtrl(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput linear, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput lr_power, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceSparseApplyFtrl(var, accum, linear, grad, indices, lr, l1, l2, lr_power, use_locking, operName);
		}
	}
}
