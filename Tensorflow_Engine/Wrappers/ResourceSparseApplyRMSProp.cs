using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceSparseApplyRMSProp(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput ms, TensorFlow.TFOutput mom, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput momentum, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceSparseApplyRMSProp(var, ms, mom, lr, rho, momentum, epsilon, grad, indices, use_locking, operName);
		}
	}
}
