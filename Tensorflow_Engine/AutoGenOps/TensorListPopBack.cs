using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorListPopBack(this TFGraph graph, TensorFlow.TFOutput input_handle, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.TensorListPopBack(input_handle, element_dtype, operName);
		}
	}
}
