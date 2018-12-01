using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyCenteredRMSProp(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput mg, TensorFlow.TFOutput ms, TensorFlow.TFOutput mom, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput momentum, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyCenteredRMSProp(var, mg, ms, mom, lr, rho, momentum, epsilon, grad, use_locking, operName);
		}
	}
}
