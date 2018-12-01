using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyAdadelta(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput accum_update, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyAdadelta(var, accum, accum_update, lr, rho, epsilon, grad, use_locking, operName);
		}
	}
}
