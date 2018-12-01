using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseApplyAdagradDA(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput gradient_accumulator, TensorFlow.TFOutput gradient_squared_accumulator, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput global_step, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.SparseApplyAdagradDA(var, gradient_accumulator, gradient_squared_accumulator, grad, indices, lr, l1, l2, global_step, use_locking, operName);
		}
	}
}
