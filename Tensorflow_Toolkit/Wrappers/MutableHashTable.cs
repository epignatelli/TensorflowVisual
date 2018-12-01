using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutableHashTable(TFGraph graph, TensorFlow.TFDataType key_dtype, TensorFlow.TFDataType value_dtype, string container=null, string shared_name=null, System.Boolean? use_node_name_sharing=null, string operName=null)
		{
			return graph.MutableHashTable(key_dtype, value_dtype, container, shared_name, use_node_name_sharing, operName);
		}
	}
}
