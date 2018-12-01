using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPoolGradV2(this TFGraph graph, TensorFlow.TFOutput orig_input, TensorFlow.TFOutput orig_output, TensorFlow.TFOutput grad, TensorFlow.TFOutput ksize, TensorFlow.TFOutput strides, string padding, string data_format=null, string operName=null)
		{
			return graph.MaxPoolGradV2(orig_input, orig_output, grad, ksize, strides, padding, data_format, operName);
		}
	}
}
