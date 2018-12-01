using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseApplyAdadelta(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput accum_update, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.SparseApplyAdadelta(var, accum, accum_update, lr, rho, epsilon, grad, indices, use_locking, operName);
		}
	}
}
