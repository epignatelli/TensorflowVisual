using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyGradientDescent(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput alpha, TensorFlow.TFOutput delta, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyGradientDescent(var, alpha, delta, use_locking, operName);
		}
	}
}
