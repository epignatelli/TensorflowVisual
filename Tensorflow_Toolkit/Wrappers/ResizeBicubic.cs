using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeBicubic(TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput size, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeBicubic(images, size, align_corners, operName);
		}
	}
}
