using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FusedPadConv2D(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, TensorFlow.TFOutput filter, string mode, long[] strides, string padding, string operName=null)
		{
			return graph.FusedPadConv2D(input, paddings, filter, mode, strides, padding, operName);
		}
	}
}
