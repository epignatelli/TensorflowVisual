using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyRMSProp(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput ms, TensorFlow.TFOutput mom, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput momentum, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ApplyRMSProp(var, ms, mom, lr, rho, momentum, epsilon, grad, use_locking, operName);
		}
	}
}
