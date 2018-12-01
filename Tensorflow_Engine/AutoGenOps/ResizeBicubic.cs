using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeBicubic(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput size, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeBicubic(images, size, align_corners, operName);
		}
	}
}
