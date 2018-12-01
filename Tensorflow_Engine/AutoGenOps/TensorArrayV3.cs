using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorArrayV3(this TFGraph graph, TensorFlow.TFOutput size, TensorFlow.TFDataType dtype, TensorFlow.TFShape element_shape=null, System.Boolean? dynamic_size=null, System.Boolean? clear_after_read=null, System.Boolean? identical_element_shapes=null, string tensor_array_name=null, string operName=null)
		{
			return graph.TensorArrayV3(size, dtype, element_shape, dynamic_size, clear_after_read, identical_element_shapes, tensor_array_name, operName);
		}
	}
}
