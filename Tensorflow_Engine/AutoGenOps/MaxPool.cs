using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MaxPool(this TFGraph graph, TensorFlow.TFOutput input, long[] ksize, long[] strides, string padding, string data_format=null, string operName=null)
		{
			return graph.MaxPool(input, ksize, strides, padding, data_format, operName);
		}
	}
}
