using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPoolGradWithArgmax(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput grad, TensorFlow.TFOutput argmax, long[] ksize, long[] strides, string padding, string operName=null)
		{
			return graph.MaxPoolGradWithArgmax(input, grad, argmax, ksize, strides, padding, operName);
		}
	}
}
