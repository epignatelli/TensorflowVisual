using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseSoftmax(this TFGraph graph, TensorFlow.TFOutput sp_indices, TensorFlow.TFOutput sp_values, TensorFlow.TFOutput sp_shape, string operName=null)
		{
			return graph.SparseSoftmax(sp_indices, sp_values, sp_shape, operName);
		}
	}
}
