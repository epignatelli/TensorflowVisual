using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LRNGrad(TFGraph graph, TensorFlow.TFOutput input_grads, TensorFlow.TFOutput input_image, TensorFlow.TFOutput output_image, long? depth_radius=null, System.Single? bias=null, System.Single? alpha=null, System.Single? beta=null, string operName=null)
		{
			return graph.LRNGrad(input_grads, input_image, output_image, depth_radius, bias, alpha, beta, operName);
		}
	}
}
