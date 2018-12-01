using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPoolGradGradWithArgmax(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput grad, TensorFlow.TFOutput argmax, long[] ksize, long[] strides, string padding, string operName=null)
		{
			return graph.MaxPoolGradGradWithArgmax(input, grad, argmax, ksize, strides, padding, operName);
		}
	}
}
