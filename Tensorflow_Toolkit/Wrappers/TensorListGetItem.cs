using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListGetItem(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFOutput index, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.TensorListGetItem(input_handle, index, element_dtype, operName);
		}
	}
}
