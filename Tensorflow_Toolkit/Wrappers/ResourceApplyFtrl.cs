using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ResourceApplyFtrl(TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput linear, TensorFlow.TFOutput grad, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput lr_power, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ResourceApplyFtrl(var, accum, linear, grad, lr, l1, l2, lr_power, use_locking, operName);
		}
	}
}
