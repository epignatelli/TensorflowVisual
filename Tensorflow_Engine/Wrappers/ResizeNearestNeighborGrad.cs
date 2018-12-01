using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeNearestNeighborGrad(this TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput size, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeNearestNeighborGrad(grads, size, align_corners, operName);
		}
	}
}
