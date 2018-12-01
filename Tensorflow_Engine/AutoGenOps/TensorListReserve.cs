using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListReserve(this TFGraph graph, TensorFlow.TFOutput element_shape, TensorFlow.TFOutput num_elements, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.TensorListReserve(element_shape, num_elements, element_dtype, operName);
		}
	}
}
