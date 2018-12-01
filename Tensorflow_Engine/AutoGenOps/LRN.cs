using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LRN(this TFGraph graph, TensorFlow.TFOutput input, long? depth_radius=null, System.Single? bias=null, System.Single? alpha=null, System.Single? beta=null, string operName=null)
		{
			return graph.LRN(input, depth_radius, bias, alpha, beta, operName);
		}
	}
}
