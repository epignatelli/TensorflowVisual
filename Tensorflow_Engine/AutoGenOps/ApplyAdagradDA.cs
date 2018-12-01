using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApplyAdagradDA(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput gradient_accumulator, TensorFlow.TFOutput gradient_squared_accumulator, TensorFlow.TFOutput grad, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput global_step, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ApplyAdagradDA(var, gradient_accumulator, gradient_squared_accumulator, grad, lr, l1, l2, global_step, use_locking, operName);
		}
	}
}
