using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseApplyAdagrad(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput lr, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, System.Boolean? use_locking=null, System.Boolean? update_slots=null, string operName=null)
		{
			return graph.SparseApplyAdagrad(var, accum, lr, grad, indices, use_locking, update_slots, operName);
		}
	}
}