using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Dilation2D(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, long[] strides, long[] rates, string padding, string operName=null)
		{
			return graph.Dilation2D(input, filter, strides, rates, padding, operName);
		}
	}
}
