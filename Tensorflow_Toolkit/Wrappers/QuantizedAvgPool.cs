using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedAvgPool(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_input, TensorFlow.TFOutput max_input, long[] ksize, long[] strides, string padding, string operName=null)
		{
			return graph.QuantizedAvgPool(input, min_input, max_input, ksize, strides, padding, operName);
		}
	}
}
