using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListStack(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFDataType element_dtype, long? num_elements=null, string operName=null)
		{
			return graph.TensorListStack(input_handle, element_dtype, num_elements, operName);
		}
	}
}
