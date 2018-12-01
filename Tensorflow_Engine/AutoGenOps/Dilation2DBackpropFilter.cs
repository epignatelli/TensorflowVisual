using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dilation2DBackpropFilter(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, TensorFlow.TFOutput out_backprop, long[] strides, long[] rates, string padding, string operName=null)
		{
			return graph.Dilation2DBackpropFilter(input, filter, out_backprop, strides, rates, padding, operName);
		}
	}
}
