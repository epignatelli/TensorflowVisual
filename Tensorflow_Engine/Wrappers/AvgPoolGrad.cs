using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AvgPoolGrad(this TFGraph graph, TensorFlow.TFOutput orig_input_shape, TensorFlow.TFOutput grad, long[] ksize, long[] strides, string padding, string data_format=null, string operName=null)
		{
			return graph.AvgPoolGrad(orig_input_shape, grad, ksize, strides, padding, data_format, operName);
		}
	}
}
