using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AvgPool(TFGraph graph, TensorFlow.TFOutput value, long[] ksize, long[] strides, string padding, string data_format=null, string operName=null)
		{
			return graph.AvgPool(value, ksize, strides, padding, data_format, operName);
		}
	}
}
