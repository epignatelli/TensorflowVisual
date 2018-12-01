using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyGradientDescent(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput alpha, TensorFlow.TFOutput delta, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyGradientDescent(var, alpha, delta, use_locking, operName);
		}
	}
}
