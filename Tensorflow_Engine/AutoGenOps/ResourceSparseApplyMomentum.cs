using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceSparseApplyMomentum(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, TensorFlow.TFOutput momentum, System.Boolean? use_locking=null, System.Boolean? use_nesterov=null, string operName=null)
		{
			return graph.ResourceSparseApplyMomentum(var, accum, lr, grad, indices, momentum, use_locking, use_nesterov, operName);
		}
	}
}
