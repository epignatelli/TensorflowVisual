using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyAdagrad(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput grad, System.Boolean? use_locking=null, System.Boolean? update_slots=null, string operName=null)
		{
			return graph.ResourceApplyAdagrad(var, accum, lr, grad, use_locking, update_slots, operName);
		}
	}
}
