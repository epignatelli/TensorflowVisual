using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyProximalGradientDescent(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput alpha, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput delta, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyProximalGradientDescent(var, alpha, l1, l2, delta, use_locking, operName);
		}
	}
}
