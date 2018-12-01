using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FusedPadConv2D(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput paddings, TensorFlow.TFOutput filter, string mode, long[] strides, string padding, string operName=null)
		{
			return graph.FusedPadConv2D(input, paddings, filter, mode, strides, padding, operName);
		}
	}
}
