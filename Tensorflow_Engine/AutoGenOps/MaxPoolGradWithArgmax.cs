using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPoolGradWithArgmax(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput grad, TensorFlow.TFOutput argmax, long[] ksize, long[] strides, string padding, string operName=null)
		{
			return graph.MaxPoolGradWithArgmax(input, grad, argmax, ksize, strides, padding, operName);
		}
	}
}
