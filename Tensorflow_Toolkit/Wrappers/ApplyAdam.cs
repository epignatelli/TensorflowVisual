using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyAdam(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput m, TensorFlow.TFOutput v, TensorFlow.TFOutput beta1_power, TensorFlow.TFOutput beta2_power, TensorFlow.TFOutput lr, TensorFlow.TFOutput beta1, TensorFlow.TFOutput beta2, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, System.Boolean? use_nesterov=null, string operName=null)
		{
			return graph.ApplyAdam(var, m, v, beta1_power, beta2_power, lr, beta1, beta2, epsilon, grad, use_locking, use_nesterov, operName);
		}
	}
}
