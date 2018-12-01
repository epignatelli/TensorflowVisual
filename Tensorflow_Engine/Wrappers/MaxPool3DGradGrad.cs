using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPool3DGradGrad(this TFGraph graph, TensorFlow.TFOutput orig_input, TensorFlow.TFOutput orig_output, TensorFlow.TFOutput grad, long[] ksize, long[] strides, string padding, string data_format=null, string operName=null)
		{
			return graph.MaxPool3DGradGrad(orig_input, orig_output, grad, ksize, strides, padding, data_format, operName);
		}
	}
}
