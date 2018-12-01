using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorListPopBack(TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.TensorListPopBack(input_handle, element_dtype, operName);
		}
	}
}
