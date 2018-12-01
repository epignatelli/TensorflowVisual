using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DepthwiseConv2dNative(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, long[] strides, string padding, string data_format=null, long[] dilations=null, string operName=null)
		{
			return graph.DepthwiseConv2dNative(input, filter, strides, padding, data_format, dilations, operName);
		}
	}
}
