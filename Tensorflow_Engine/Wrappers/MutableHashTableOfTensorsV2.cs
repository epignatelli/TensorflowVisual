using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutableHashTableOfTensorsV2(this TFGraph graph, TensorFlow.TFDataType key_dtype, TensorFlow.TFDataType value_dtype, string container=null, string shared_name=null, System.Boolean? use_node_name_sharing=null, TensorFlow.TFShape value_shape=null, string operName=null)
		{
			return graph.MutableHashTableOfTensorsV2(key_dtype, value_dtype, container, shared_name, use_node_name_sharing, value_shape, operName);
		}
	}
}
