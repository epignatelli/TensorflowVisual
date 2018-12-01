using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AvgPool3D(TFGraph graph, TensorFlow.TFOutput input, long[] ksize, long[] strides, string padding, string data_format=null, string operName=null)
		{
			return graph.AvgPool3D(input, ksize, strides, padding, data_format, operName);
		}
	}
}
