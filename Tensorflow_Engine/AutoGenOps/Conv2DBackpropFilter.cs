using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Conv2DBackpropFilter(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter_sizes, TensorFlow.TFOutput out_backprop, long[] strides, string padding, System.Boolean? use_cudnn_on_gpu=null, string data_format=null, long[] dilations=null, string operName=null)
		{
			return graph.Conv2DBackpropFilter(input, filter_sizes, out_backprop, strides, padding, use_cudnn_on_gpu, data_format, dilations, operName);
		}
	}
}
