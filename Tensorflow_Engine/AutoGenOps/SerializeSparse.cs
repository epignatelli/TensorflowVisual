using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SerializeSparse(this TFGraph graph, TensorFlow.TFOutput sparse_indices, TensorFlow.TFOutput sparse_values, TensorFlow.TFOutput sparse_shape, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.SerializeSparse(sparse_indices, sparse_values, sparse_shape, out_type, operName);
		}
	}
}
