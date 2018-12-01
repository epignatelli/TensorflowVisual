using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DepthwiseConv2dNativeBackpropInput(TFGraph graph, TensorFlow.TFOutput input_sizes, TensorFlow.TFOutput filter, TensorFlow.TFOutput out_backprop, long[] strides, string padding, string data_format=null, long[] dilations=null, string operName=null)
		{
			return graph.DepthwiseConv2dNativeBackpropInput(input_sizes, filter, out_backprop, strides, padding, data_format, dilations, operName);
		}
	}
}
