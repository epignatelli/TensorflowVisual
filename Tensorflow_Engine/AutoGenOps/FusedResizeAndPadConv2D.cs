using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FusedResizeAndPadConv2D(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput size, TensorFlow.TFOutput paddings, TensorFlow.TFOutput filter, string mode, long[] strides, string padding, System.Boolean? resize_align_corners=null, string operName=null)
		{
			return graph.FusedResizeAndPadConv2D(input, size, paddings, filter, mode, strides, padding, resize_align_corners, operName);
		}
	}
}
