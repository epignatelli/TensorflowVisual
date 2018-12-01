using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeNearestNeighborGrad(TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput size, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeNearestNeighborGrad(grads, size, align_corners, operName);
		}
	}
}
