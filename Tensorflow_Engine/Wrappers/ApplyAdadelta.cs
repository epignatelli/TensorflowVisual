using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyAdadelta(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput accum_update, TensorFlow.TFOutput lr, TensorFlow.TFOutput rho, TensorFlow.TFOutput epsilon, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ApplyAdadelta(var, accum, accum_update, lr, rho, epsilon, grad, use_locking, operName);
		}
	}
}
