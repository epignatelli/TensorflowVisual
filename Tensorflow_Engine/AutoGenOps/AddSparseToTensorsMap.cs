using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AddSparseToTensorsMap(this TFGraph graph, TensorFlow.TFOutput sparse_indices, TensorFlow.TFOutput sparse_values, TensorFlow.TFOutput sparse_shape, string container=null, string shared_name=null, string operName=null)
		{
			return graph.AddSparseToTensorsMap(sparse_indices, sparse_values, sparse_shape, container, shared_name, operName);
		}
	}
}
