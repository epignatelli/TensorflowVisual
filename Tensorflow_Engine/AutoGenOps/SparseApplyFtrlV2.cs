using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseApplyFtrlV2(this TFGraph graph, TensorFlow.TFOutput var, TensorFlow.TFOutput accum, TensorFlow.TFOutput linear, TensorFlow.TFOutput grad, TensorFlow.TFOutput indices, TensorFlow.TFOutput lr, TensorFlow.TFOutput l1, TensorFlow.TFOutput l2, TensorFlow.TFOutput l2_shrinkage, TensorFlow.TFOutput lr_power, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.SparseApplyFtrlV2(var, accum, linear, grad, indices, lr, l1, l2, l2_shrinkage, lr_power, use_locking, operName);
		}
	}
}
