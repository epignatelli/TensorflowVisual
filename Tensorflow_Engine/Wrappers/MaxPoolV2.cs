using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPoolV2(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput ksize, TensorFlow.TFOutput strides, string padding, string data_format=null, string operName=null)
		{
			return graph.MaxPoolV2(input, ksize, strides, padding, data_format, operName);
		}
	}
}
