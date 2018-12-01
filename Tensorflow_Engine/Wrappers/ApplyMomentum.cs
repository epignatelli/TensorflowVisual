using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyMomentum(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput grad, TensorFlow.TFOutput momentum, System.Boolean? use_locking=null, System.Boolean? use_nesterov=null, string operName=null)
		{
			return graph.ApplyMomentum(var, accum, lr, grad, momentum, use_locking, use_nesterov, operName);
		}
	}
}
