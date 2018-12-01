using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeNearestNeighbor(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput size, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeNearestNeighbor(images, size, align_corners, operName);
		}
	}
}
