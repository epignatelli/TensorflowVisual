using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedConv2D(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, TensorFlow.TFOutput min_input, TensorFlow.TFOutput max_input, TensorFlow.TFOutput min_filter, TensorFlow.TFOutput max_filter, long[] strides, string padding, TensorFlow.TFDataType? out_type=null, long[] dilations=null, string operName=null)
		{
			return graph.QuantizedConv2D(input, filter, min_input, max_input, min_filter, max_filter, strides, padding, out_type, dilations, operName);
		}
	}
}
