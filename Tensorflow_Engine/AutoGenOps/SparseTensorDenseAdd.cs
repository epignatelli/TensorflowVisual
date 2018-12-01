using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseTensorDenseAdd(this TFGraph graph, TensorFlow.TFOutput a_indices, TensorFlow.TFOutput a_values, TensorFlow.TFOutput a_shape, TensorFlow.TFOutput b, string operName=null)
		{
			return graph.SparseTensorDenseAdd(a_indices, a_values, a_shape, b, operName);
		}
	}
}
