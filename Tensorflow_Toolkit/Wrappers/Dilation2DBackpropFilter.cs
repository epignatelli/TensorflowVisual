using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dilation2DBackpropFilter(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, TensorFlow.TFOutput out_backprop, long[] strides, long[] rates, string padding, string operName=null)
		{
			return graph.Dilation2DBackpropFilter(input, filter, out_backprop, strides, rates, padding, operName);
		}
	}
}
