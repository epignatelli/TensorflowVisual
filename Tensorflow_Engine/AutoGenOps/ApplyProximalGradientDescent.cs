using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyProximalGradientDescent(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput alpha, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput delta, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ApplyProximalGradientDescent(var, alpha, l1, l2, delta, use_locking, operName);
		}
	}
}
