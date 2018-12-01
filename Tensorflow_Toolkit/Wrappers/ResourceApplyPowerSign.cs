using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyPowerSign(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput m, TensorFlow.TFOutput lr, TensorFlow.TFOutput logbase, TensorFlow.TFOutput sign_decay, TensorFlow.TFOutput beta, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyPowerSign(var, m, lr, logbase, sign_decay, beta, grad, use_locking, operName);
		}
	}
}
