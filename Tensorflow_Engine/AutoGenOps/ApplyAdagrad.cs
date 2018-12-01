using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyAdagrad(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, System.Boolean? update_slots=null, string operName=null)
		{
			return graph.ApplyAdagrad(var, accum, lr, grad, use_locking, update_slots, operName);
		}
	}
}
