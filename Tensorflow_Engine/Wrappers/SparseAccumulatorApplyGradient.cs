using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation SparseAccumulatorApplyGradient(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput local_step, TensorFlow.TFOutput gradient_indices, TensorFlow.TFOutput gradient_values, TensorFlow.TFOutput gradient_shape, System.Boolean has_known_shape, string operName=null)
		{
			return graph.SparseAccumulatorApplyGradient(handle, local_step, gradient_indices, gradient_values, gradient_shape, has_known_shape, operName);
		}
	}
}
