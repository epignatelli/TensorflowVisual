using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutableDenseHashTable(this TFGraph graph, TensorFlow.TFOutput empty_key, TensorFlow.TFDataType value_dtype, string container=null, string shared_name=null, System.Boolean? use_node_name_sharing=null, TensorFlow.TFShape value_shape=null, long? initial_num_buckets=null, System.Single? max_load_factor=null, string operName=null)
		{
			return graph.MutableDenseHashTable(empty_key, value_dtype, container, shared_name, use_node_name_sharing, value_shape, initial_num_buckets, max_load_factor, operName);
		}
	}
}