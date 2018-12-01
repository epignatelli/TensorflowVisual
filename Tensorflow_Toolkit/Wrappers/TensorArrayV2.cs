using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayV2(TFGraph graph, TensorFlow.TFOutput size, TensorFlow.TFDataType dtype, TensorFlow.TFShape element_shape=null, System.Boolean? dynamic_size=null, System.Boolean? clear_after_read=null, string tensor_array_name=null, string operName=null)
		{
			return graph.TensorArrayV2(size, dtype, element_shape, dynamic_size, clear_after_read, tensor_array_name, operName);
		}
	}
}
