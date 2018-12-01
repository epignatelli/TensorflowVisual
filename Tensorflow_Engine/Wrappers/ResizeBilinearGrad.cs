using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResizeBilinearGrad(this TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput original_image, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.ResizeBilinearGrad(grads, original_image, align_corners, operName);
		}
	}
}
