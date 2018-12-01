using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListReserve(TFGraph graph, TensorFlow.TFOutput element_shape, TensorFlow.TFOutput num_elements, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.TensorListReserve(element_shape, num_elements, element_dtype, operName);
		}
	}
}
