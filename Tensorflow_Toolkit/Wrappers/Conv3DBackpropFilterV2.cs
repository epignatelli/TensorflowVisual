using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Conv3DBackpropFilterV2(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter_sizes, TensorFlow.TFOutput out_backprop, long[] strides, string padding, string data_format=null, long[] dilations=null, string operName=null)
		{
			return graph.Conv3DBackpropFilterV2(input, filter_sizes, out_backprop, strides, padding, data_format, dilations, operName);
		}
	}
}
