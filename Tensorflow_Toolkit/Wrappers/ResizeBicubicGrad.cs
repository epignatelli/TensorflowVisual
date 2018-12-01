using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeBicubicGrad(TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput original_image, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeBicubicGrad(grads, original_image, align_corners, operName);
		}
	}
}
