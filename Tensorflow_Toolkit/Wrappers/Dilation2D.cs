using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dilation2D(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, long[] strides, long[] rates, string padding, string operName=null)
		{
			return graph.Dilation2D(input, filter, strides, rates, padding, operName);
		}
	}
}
