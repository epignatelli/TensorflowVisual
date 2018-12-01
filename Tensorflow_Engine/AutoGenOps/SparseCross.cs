using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SparseCross(this TFGraph graph, TensorFlow.TFOutput[] indices, TensorFlow.TFOutput[] values, TensorFlow.TFOutput[] shapes, TensorFlow.TFOutput[] dense_inputs, System.Boolean hashed_output, long num_buckets, long hash_key, TensorFlow.TFDataType out_type, TensorFlow.TFDataType internal_type, string operName=null)
		{
			return graph.SparseCross(indices, values, shapes, dense_inputs, hashed_output, num_buckets, hash_key, out_type, internal_type, operName);
		}
	}
}
